# Rancor Microworld Simulator — **UnitModel Reference**

This page describes the data contract (`UnitModelBaseDTO`) and callable actions for a single **Rancor unit**. Use it when wiring HMIs, etc.

---

## 1. Runtime Layers & Data Flow

```
Physical Model ──► Edge Instrumentation ──► Controllers ──► HMI
   ▲   │                                          │
   └───┴──────────── Operator Commands ◄──────────┘
```

- **Physical Model** – core thermal‑hydraulic state (pressure, temperature, mass‑flow).
- **Edge Instrumentation** – sensors/actuators translating physical ↔ virtual signals.
- **Controllers** – PID & logic blocks acting on sensed values.
- **HMI** – read‑outs/indicators presented to operators.

---

## 2. Property Naming & Access Rules

| Suffix / Layer                | Example                      | Writable?                      | Bind to HMI?         |
| ----------------------------- | ---------------------------- | ------------------------------ | -------------------- |
| \_Indicator                   | `HotLegTemperatureIndicator` | **No** (simulation overwrites) | ✅ Gauge/label        |
| *(none)* – controller/command | `RodCtrlTargetRX`            | **Yes** via `/setproperty`     | Use sliders, buttons |
| *(none)* – physical           | `PrimaryPressure`            | **No**                         | ✅ Trend plot         |

**Key points**

1. Only **non‑Indicator** properties are candidates for `/setproperty`.
2. **Controllers** use the Indicator values as process-veriables.
4. HMI widgets should show an *Indicator* value e.g. `SGALevelIndicator` and not `SGALevel`.

## 3. Exposed Public Methods In UnitModel (`/executemethod`)

Call signature:

```
POST /api/units/{unitId}/executemethod?methodName={Name}
```

| Subsystem            | Method                    | Effect                                |
| -------------------- | ------------------------- | ------------------------------------- |
| **Alarms**           | `SilenceAlarms`           | Acknowledge & mute alarms             |
| **Primary**          | `SetRodCtrlGo`            | Resume automatic rod motion           |
|                      | `SetRodCtrlHold`          | Hold rods                             |
|                      | `ActivateSafetyInjection` | Initiate safety‑injection             |
|                      | `SetRodCtrlAuto`          | Reactivity control → automatic        |
|                      | `SetRodCtrlManual`        | Reactivity control → manual           |
|                      | `IncreaseTargetRX`        | Raise reactor power target by 5 %     |
|                      | `DecreaseTargetRX`        | Lower reactor power target by 5 %     |
|                      | `ToggleDiluteBoron`       | Start/stop boron dilution             |
|                      | `ToggleConcentrateBoron`  | Start/stop boron concentration        |
|                      | `ScramReactor`            | Emergency reactor SCRAM               |
| **Steam Generators** | `SetSGACtrlAuto`          | SG‑A level control → automatic        |
|                      | `SetSGBCtrlAuto`          | SG‑B level control → automatic        |
|                      | `SetSGACtrlManual`        | SG‑A manual mode                      |
|                      | `SetSGBCtrlManual`        | SG‑B manual mode                      |
| **Turbine Control**  | `ScramTurbine`            | Trip turbine & isolate steam          |
|                      | `IncreaseLoad`            | Raise generator load by 5 %           |
|                      | `DecreaseLoad`            | Reduce generator load by 5 %          |
|                      | `LatchTurbine`            | Close stop valves for synchronisation |
|                      | `SyncGenerator`           | Synchronise generator to grid         |

For additional guidance see the `p3\db\procedures\op-001_startup_2col.yaml` procedure in the release.

---

## 4. MessagePack Contract

Both JSON and MessagePack payloads follow the exact field order defined in `UnitModelBaseDTO`. For binary clients:

```csharp
var dto = MessagePackSerializer.Deserialize<UnitModelBaseDTO>(payload);
```

