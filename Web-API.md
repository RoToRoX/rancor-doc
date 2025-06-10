# Rancor Microworld Simulator — WebAPI End‑User Guide

## Overview

Rancor has a web api for communicating between server and client instances. 
When launched as "Server" Rancor runs the simulation model and the HMI windows (unless ran as HEADLESS). 
When ran as Client only the HMI windows are ran and the Client communicates with a Server over the Web-API.

This document enumerates every public HTTP endpoint exposed by the **Rancor Microworld Simulator** (multi‑unit SMR simplified simulator). Use it as a reference when integrating dashboards, test harnesses, or automation scripts.

---

## 1. Base URL & General Conventions

| Element            | Default                                                                                   | Notes                                            |
| ------------------ | ----------------------------------------------------------------------------------------- | ------------------------------------------------ |
| **Base URL**       | `http://<host>:7200/`                                                                     | Change the port in `appsettings.json` if needed. |
| **Content Types**  | `application/json` (REST) / `application/octet-stream` (MessagePack)                      |                                                  |
| **Unit Id Format** | `"1"`, `"A"`, etc. Must match the UnitNumber in the scenario files.                       | Keys in `RancorSim.UnitModels`.                  |
| **HTTP Codes**     | `200 OK` on success, `400 Bad Request` on validation failure, `500` on server faults.     |                                                  |

### 1.1 Authentication & Safety

- Most operations are open; **simulator shutdown** requires a *7‑digit odd prime* **PIN code** (see § 3.3). The helper `PinCodeValidator.CheckPin(int)` enforces:
  - `number >= 1_000_000`
  - odd
  - prime

---

## 2. Unit‑Scoped Endpoints (`/api/units/...`)

### 2.1 Get Unit State — JSON (non-preferred)

```
GET /api/units/{unitId}
```

Returns the live state of one unit serialized as JSON. The schema matches `` (supplied separately).

> Example
>
> ```bash
> curl -s http://localhost:7200/api/units/1 | jq .PowerOutputMW
> ```

### 2.2 Set Property

```
POST /api/units/{unitId}/setproperty?propertyName={prop}&value={val}
```

- **propertyName** — exact `DependencyProperty` name on the Unit ViewModel.
- **value** — string representation (bool, int, double, etc.).

Returns `200 OK` after the assignment is queued on the UI thread.

> Example – start Recirc Pump A
>
> ```bash
> curl -X POST "http://localhost:7200/api/units/1/setproperty?propertyName=RecircPumpA&value=true"
> ```

### 2.3 Execute Method

```
POST /api/units/{unitId}/executemethod?methodName={name}
```

Invokes an exposed public method on the Unit ViewModel.

> Example – turbine SCRAM
>
> ```bash
> curl -X POST "http://localhost:7200/api/units/1/executemethod?methodName=ScramTurbine"
> ```

For full list of methods see:
[UnitModel Reference](UnitModel-Reference.md)
---

## 3. Simulator‑Wide Endpoints (`/api/rancorsim/...`)

### 3.1 Set Run State

```
POST /api/rancorsim/setstate/{state}
```

- **state** — `run` | `freeze`

`run` resumes normal time‑step progression; `freeze` pauses.

### 3.2 Snapshot (IC File)

```
POST /api/rancorsim/snap
```

Captures the full simulator state to `Snaps/YYYY‑MM‑DD_HH‑MM‑SS.json` under the working directory. Useful for regression tests.

### 3.3 Terminate Simulator

```
POST /api/rancorsim/exit/{pinCode}
```

- **pinCode** (path) — 7‑digit odd prime (see § 1.1).

On success the process calls `RancorSim.Exit()` and shuts down the WPF host.

> Example (assuming `1000023` is prime)
>
> ```bash
> curl -X POST http://localhost:7200/api/rancorsim/exit/1000023
> ```

---

## 4. Logging Endpoint (`/log/...`)

### 4.1 Bare‑Metal Append

```
POST /log/baremetal?filetype={kind}
Body: <plain‑text>
```

- **filetype** — `human` | `event` | `dynamic_view_model` | `sim_api`

Proxies logging to the Server LogManager. Appends the raw body text to the corresponding logfile (paths resolved by `LogManager`). No formatting is added.

---

## 5. High‑Performance Binary Endpoints (`/messagepack/...`) - Preferred over JSON

These mirror the REST GETs but return **MessagePack‑encoded** DTOs for reduced payload size.

### 5.1 Unit State — MessagePack

```
GET /messagepack/units/{unitId}
```

Returns `application/octet-stream`; deserialize with the provided [`UnitModelBaseDTO`](https://github.com/RoToRoX/rancor-doc/blob/master/UnitModelBaseDTO.cs) contract.

### 5.2 Whole Simulator State — MessagePack

```
GET /messagepack/rancorsim
```

Binary payload matching [`RancorSimBaseDTO`](https://github.com/RoToRoX/rancor-doc/blob/master/RancorSimBaseDTO.cs).

---

## 6. Error Handling Summary

| HTTP Code | Cause                             |
| --------- | --------------------------------- |
| 200       | Successful operation              |
| 400       | Invalid parameters, bad PIN, etc. |
| 500       | Unhandled server exception        |

---

## 7. Quick‑Start Sequence

1. **Pause** simulation → `POST /api/rancorsim/setstate/freeze`
2. **Modify** properties on one or more units.
3. **Resume** simulation → `POST /api/rancorsim/setstate/run`
4. **Snapshot** when desired.

---

### Resources

- [`UnitModelBaseDTO` (fields & order)](https://github.com/RoToRoX/rancor-doc/blob/master/UnitModelBaseDTO.cs)
- [`RancorSimBaseDTO` (fields & order)](https://github.com/RoToRoX/rancor-doc/blob/master/RancorSimBaseDTO.cs)
- [UnitModel Reference](UnitModel-Reference.md)
