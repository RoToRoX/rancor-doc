# **3. Generation**

RANCOR includes an economic component that demonstrates how plant operation and electrical generation can affect the simulated financial performance of the plant.

The economics portion of the simulation is divided into two main areas:

* **Revenue** — Covers how the simulated plant earns revenue and the expenses, penalties, and fines that can affect it.

* **Demand** — Covers the demand side of the RANCOR economic model and how it relates to plant generation.

The Generation training is also divided into two sections based on the level of information needed:

* **Trainee** — Covers the essential concepts needed to understand revenue and demand while operating the RANCOR simulation. This section focuses on the broader concepts without going into the detailed calculations behind them.

* **Instructor** — Provides a more detailed explanation of how revenue and demand work within RANCOR. This section includes equations, calculations, settings, and terminology that instructors may need to understand but trainees do not need for normal simulation operation.

## **3.1 Trainee Section**

The Generation portion of RANCOR introduces the economic side of operating the simulated plant. During a trial, your decisions can affect both the amount of simulated revenue you earn and how well your generation matches demand.

As a trainee, there are two main concepts to understand:

* **Revenue** — The economic value associated with operating and generating electricity.
* **Demand** — The amount of generation needed from the plant.

Your goal is not simply to generate as much power as possible. You should pay attention to demand, plant conditions, and the economic consequences of your actions throughout the simulation.

### **3.1.1 Revenue**

RANCOR keeps a running economic score as the simulation operates. Revenue can be earned through generation, while operating expenses, penalties, and fines can decrease your score.

#### **Synced to the Grid**

When the turbine/generator is **synced to the grid**, the unit can earn revenue from the electricity it generates.

Revenue is based on **gross generation**, which represents generation before the electrical power used by the plant's pumps is accounted for.

!!! tip "Remember"
**Synced to the grid = the unit can earn revenue.**

#### **Not Synced to the Grid**

When the turbine/generator is **not synced to the grid**, the unit does **not** earn generation revenue.

The plant's pumps may still be operating and consuming electricity, so the unit can continue to have an economic cost even though it is not earning revenue.

!!! tip "Remember"
**Not synced to the grid = no generation revenue, but the unit can still have costs.**

#### **Operating Expenses**

Operating the unit also has an ongoing expense. This expense continues while the simulation is running and is applied whether the unit is synced to the grid or not.

This means that simply keeping the unit running does not automatically improve your economic score. You should consider both the revenue being earned and the costs associated with operation.

#### **Demand-Band Penalties**

RANCOR compares your **gross generation** with the current **demand**.

The goal is to keep generation within **5 MW of demand**. If generation remains outside this range for more than **20 seconds**, a demand-band penalty contract is triggered.

For example, if demand is:

$$
100\text{ MW}
$$

the acceptable generation range is:

$$
95\text{ MW} \leq Gross \leq 105\text{ MW}
$$

!!! important
You do not need to match demand perfectly, but you should try to remain within the allowed **±5 MW demand band**.

#### **Reactor Trip Fine**

Plant conditions can also affect your economic score.

If the reactor's core safety interlock trips when the vessel temperature exceeds **750°F**, the reactor is SCRAMMED and a one-time **$10,000 Reactor Trip Fine** is applied if the interlock was not already engaged.

A **SCRAM** is an automatic reactor shutdown used when the reactor needs to shut down for safety reasons.

!!! warning "Reactor Trip"
A reactor trip affects more than reactor operation—it can also have a significant impact on your economic score.

#### **Fleet Performance**

RANCOR also considers the performance of the **entire fleet**.

The economic values from the individual units are combined into a fleet-wide value. The simulation also compares total fleet generation with GridDemand. If the fleet continuously produces more than the allowed amount above demand, an overproduction fine can be applied.

This means that the performance of one unit can contribute to the overall economic performance of the fleet.

### **3.1.2 Demand**

**Demand** represents how much generation is needed during the simulation.

Demand does not remain at one constant value. RANCOR uses a 24-hour demand profile, and the pattern changes depending on whether the selected season is **winter, spring, summer, or fall**.

As the trial progresses, demand changes at different points throughout the simulation. More frequent demand changes result in smaller steps between demand levels, while fewer changes result in larger steps.

As a trainee, you do not need to calculate how RANCOR creates these demand values. The important concept is that **demand can change throughout the trial**, and your generation should respond accordingly.

#### **Matching Generation to Demand**

One of the main goals of the Generation portion of RANCOR is to balance **generation and demand**.

If generation is too low, the plant is not matching the amount of generation being requested. However, producing too much is not necessarily better. RANCOR can also apply penalties when generation exceeds the allowed demand limits.

As demand changes, continue monitoring:

* Current demand
* Current generation
* Whether the unit is synced to the grid
* The difference between generation and demand
* Your running economic score
* Plant conditions

!!! tip "Key Concept"
The goal is not to produce the maximum amount of power at all times. Instead, pay attention to **what the grid is demanding and how closely your generation matches it**.

### **3.1.3 Putting Revenue and Demand Together**

Revenue and demand work together throughout the simulation.

When the unit is synced to the grid, generation can earn revenue. At the same time, operating expenses and other costs continue to affect the running score. Demand determines how much generation is needed, and penalties or fines can affect the score when certain conditions occur.

As a trainee, focus on three questions:

1. **How much generation is currently needed?**
2. **How closely does my generation match that demand?**
3. **How are my operating decisions affecting the running economic score?**

Understanding these relationships will help you make more informed decisions during the RANCOR simulation.


# **3.2 Instructor Section**

## **3.2.1 Revenue**

Revenue represents the economic side of producing electricity within the RANCOR simulation. As the simulation operates, a running ledger tracks changes in revenue along with applicable expenses, penalties, and fines.

The Revenue section includes:

- Revenue When Synced to the Grid
- Revenue When Not Synced to the Grid
- Ongoing Operating Expense
- Demand-Band Penalty Contracts
- Reactor Trip Fine
- Fleet-Level Aggregation and Fine

### **3.2.1.1 Revenue When Synced to the Grid**

When the plant is synced to the grid, RANCOR calculates revenue based on the amount of gross generation being produced.

Before looking at the revenue calculation, it is important to understand the difference between gross and net generation.

#### **3.2.1.1.1 Gross vs. Net Generation**

Gross generation is the total generation before power used by the plant's pumps is accounted for.

Net generation is what remains after pump power is subtracted from gross generation.

!!! important
    When the plant is synced to the grid, RANCOR bills revenue based on gross generation, not net generation.

Gross generation is determined using:

$$
\text{Gross Generation} = \frac{d}{dt}(sgQ)k
$$

Where:

| Symbol | Definition |
| --- | --- |
| $\frac{d}{dt}$ | Derivative, or rate of change |
| $sgQ$ | Secondary-side thermal power |
| $k$ |	Scaling factor |

The completed calculation provides the gross generation value used by the simulator.

#### **3.2.1.1.2 Net Generation**

Although revenue is based on gross generation, net generation is still useful for understanding the overall generation of the plant.

Net generation is calculated as:

$$
Net = Gross - PumpPower
$$

If you already know the net generation and pump power, this relationship can also be rearranged to find gross generation:

$$
Gross = Net + PumpPower
$$

The pump power used in the net generation calculation comes from the reactor coolant pumps and feedwater pumps.

$$
PumpPower = ReactorCoolantPump + FeedWaterPump
$$

This explains why gross and net generation can be different even though revenue is calculated from the gross value.

#### **3.2.1.1.3 Revenue and Simulation Ticks**

RANCOR continuously updates its economic calculations while the simulation is running. Each model update is referred to as a **tick**.

By default, RANCOR updates every **100 milliseconds (ms)**:

$$
1\ tick = 100\ ms = 0.1\ seconds
$$

The tick interval is **configurable**, meaning the amount of time between model updates can be changed. However, **100 ms is the default setting**.

For each tick, RANCOR uses the current gross generation and the amount of model time that has passed:

$$
GeneratedEnergy = Gross \times dt \times 1000
$$

Where:

| Symbol            | Definition                                       |
| ----------------- | ------------------------------------------------ |
| $Gross$           | Current gross generation                         |
| $dt$              | Amount of model time that passes during the tick |
| $GeneratedEnergy$ | Generation calculated for the current tick       |

At the default 100 ms update interval:

$$
dt = 0.1\text{ seconds}
$$

The generation calculated during the tick is then combined with the electrical rate to determine the revenue earned during that interval:

$$
Revenue_{tick} = GeneratedEnergy \times ElectricRate
$$

Where:

| Symbol           | Definition                             |
| ---------------- | -------------------------------------- |
| $ElectricRate$   | Electrical rate used by the simulation |
| $Revenue_{tick}$ | Revenue earned during the current tick |

The electrical rate used by RANCOR is:

$$
ElectricRate = $0.10/\text{kWh}
$$

As additional ticks occur, the calculated revenue is added to the running ledger, allowing the **Revenue** display to continuously update throughout the simulation.

!!! note
Although the default tick interval is **100 ms**, it is configurable. Therefore, calculations should use the current $\Delta t$ rather than assuming that every simulation will always use a 100 ms update interval.


### **3.2.1.2 Revenue When Not Synced to the Grid**

When the turbine/generator is **not synced to the grid**, the unit does **not generate revenue**. However, the plant's pumps are still consuming electricity.

Instead of earning revenue, the unit is charged for the electricity consumed by its pumps during that period.

The cost is calculated as:

$$
Cost = PumpPower \times dt \times 1000 \times ElectricRate
$$

This calculated cost becomes the **GeneratedValue** for that simulation tick:

$$
GeneratedValue = Cost
$$

Where:

| Symbol           | Definition                                                |
| ---------------- | --------------------------------------------------------- |
| $Cost$           | Cost of operating the pumps while not synced              |
| $PumpPower$      | Power consumed by the reactor coolant and feedwater pumps |
| $dt$             | Amount of simulation time that passes during the tick     |
| $ElectricRate$   | Cost of electricity                                       |
| $GeneratedValue$ | Value calculated by the simulator for the current tick    |

The key difference between the two conditions is:

* **Synced to the grid:** The unit can earn revenue from gross generation.
* **Not synced to the grid:** The unit earns **no revenue** and is instead charged for the electricity consumed by its pumps.

!!! important
    A unit that is not synced to the grid can still have an economic cost because its pumps continue to consume electricity.


### **3.2.1.3 Ongoing Operating Expense**

In addition to revenue and generation costs, RANCOR applies an **ongoing operating expense** as the simulation runs.

This expense is applied during **every simulation tick**, regardless of whether the turbine/generator is **synced to the grid or not synced to the grid**.

The operating expense for each tick is calculated as:

$$
Expense = OperatingExpenseRate \times dt
$$

Where:

| Symbol                 | Definition                                            |
| ---------------------- | ----------------------------------------------------- |
| $Expense$              | Operating expense applied during the current tick     |
| $OperatingExpenseRate$ | Cost of operating the unit per model time unit        |
| $dt$                   | Amount of simulation time that passes during the tick |

The operating expense rate used by RANCOR is:

$$
OperatingExpenseRate = $250 \text{ per model time unit}
$$

Unlike revenue, the ongoing operating expense is **always subtracted** from the running ledger.

!!! important
    The ongoing operating expense is applied every tick whether the unit is synced to the grid or not.


### **3.2.1.4 Demand-Band Penalty Contracts**

RANCOR compares the unit's **gross generation** to the current **demand**. The goal is to keep gross generation within **5 MW of demand**.

The simulator checks the difference using:

$$
|Gross - Demand| > 5\text{ MW}
$$

The absolute value means that the difference can be either above or below demand. If gross generation differs from demand by more than **5 MW**, the unit is considered outside the demand band.

For example, if demand is **100 MW**, the acceptable band would be:

$$
95\text{ MW} \leq Gross \leq 105\text{ MW}
$$

#### **3.2.1.4.1 Time Outside the Demand Band**

When generation is outside the **±5 MW demand band**, RANCOR begins accumulating **TimeOutsideDemandBand**.

If:

$$
TimeOutsideDemandBand > 20\text{ seconds}
$$

a penalty contract is triggered.

When this occurs:

1. A **ContractCost** is charged.
2. **PenaltyContracts** increases.
3. The demand-band timer resets.

The current fixed contract cost is:

$$
ContractCost = $0
$$

!!! important
    Being outside the ±5 MW demand band does not immediately trigger the contract. The unit must remain outside the band long enough for **TimeOutsideDemandBand** to exceed **20 seconds**.


### **3.2.1.5 Reactor Trip Fine**

RANCOR applies a **one-time fine** if the reactor's core safety interlock trips.

The safety interlock is triggered when the reactor vessel temperature exceeds:

$$
T_{vessel} > 750^\circ F
$$

If the safety interlock was **not already engaged**, the simulator applies a one-time:

$$
ReactorTripFine = $10{,}000
$$

When the trip occurs:

1. **$10,000 is deducted** from the simulation's running economic model.
2. The reactor is **SCRAMMED**.

Because this is a **one-time fine**, the $10,000 charge is applied when the safety interlock initially trips rather than being repeatedly charged while the interlock remains engaged.

A **SCRAM** is an automatic reactor shutdown that occurs when the reactor needs to shut down for safety reasons. In RANCOR, when the specified safety interlock is triggered, the reactor is automatically SCRAMMED. This stops reactor operation and also results in the one-time Reactor Trip Fine described above.

!!! warning "Reactor Trip"
    If vessel temperature exceeds **750°F**, the core safety interlock trips, the reactor is SCRAMMED, and a **$10,000 Reactor Trip Fine** is applied if the interlock was not already engaged.

### **3.2.1.6 Fleet-Level Aggregation and Fine**

RANCOR also tracks the economic performance of the **entire fleet**, rather than looking only at each individual unit.

#### **3.2.1.6.1 Fleet-Level Aggregation**

During every simulation tick, RANCOR adds the **GeneratedValue** from each unit together to calculate a fleet-wide **CombinedValue**.

$$
CombinedValue = \sum GeneratedValue_{unit}
$$

This allows the simulator to track the combined economic value produced by all units.

#### **3.2.1.6.2 Fleet Overproduction Fine**

RANCOR also compares the fleet's total **net generation** to the **GridDemand**.

If fleet net generation exceeds GridDemand by more than **5% continuously for more than 10 seconds**, an overproduction penalty is calculated.

The demand error can be represented as:

$$
Error = FleetNet - GridDemand
$$

The overproduction penalty is then calculated using:

$$
Penalty = 0.1 \times Error^2 \times ElectricRate
$$

Because the demand error is **squared**, the penalty increases more rapidly as the difference between fleet generation and grid demand becomes larger.

The calculated penalties accumulate as **TotalFines**.

#### **3.2.1.6.3 Final Fleet Value**

TotalFines are subtracted from the fleet's CombinedValue:

$$
FinalValue = CombinedValue - TotalFines
$$

!!! important
    The fleet overproduction fine applies when total fleet net generation remains more than **5% above GridDemand for over 10 continuous seconds**. The penalty is based on how far fleet generation exceeds demand, so larger overproduction results in a larger penalty.


### **3.2.1.7 Summary of Revenue**

RANCOR combines revenue, operating costs, penalties, and fines to track the economic performance of the plant throughout the simulation.

When a unit is **synced to the grid**, revenue is earned from gross generation using an electric rate of:

$$
ElectricRate = $0.10/\text{kWh}
$$

When calculating the overall economic value, RANCOR also accounts for several possible costs:

* **Pump Electricity Cost** — Applied when the unit is not synced to the grid.
* **Ongoing Operating Expense** — A flat operating expense of **$250 per model time unit**.
* **Demand-Band Contract Penalties** — Applied when generation remains outside the allowed demand band.
* **Reactor Trip Fine** — A one-time **$10,000 fine** when the specified reactor trip condition occurs.
* **Fleet Overproduction Fine** — A quadratic penalty applied when fleet-level Net generation remains above the allowed GridDemand threshold.

These calculations are incorporated into the unit-level **GeneratedValue** and fleet-level **CombinedValue**, which serve as the plant's running economic score during the simulation.

!!! tip "Key Concept"
    Generating more electricity does not necessarily result in a better economic score. Revenue must be considered alongside operating expenses, demand requirements, and applicable penalties or fines.


## **3.2.2 Demand**

The Demand section explains the demand side of the RANCOR economic model and how it relates to plant generation.

!!! important
    You are penalized if you don't match demand with generation within a certain error margin 

### **3.2.2.1 Grid Demand Calculation**

The per unit demand is driven by a season shaped 24-hour load curve 

Three pieces work together: 

- **1. Season Curve**
- **2. Building the Demand Schedule**
- **3. Timestep Cadence**

#### **3.2.2.1.1 Season Curve**   

RANCOR uses a **season curve** to represent how electrical demand changes throughout a 24-hour period. Each season (**winter, spring, summer, and fall**) has its own demand curve.

The seasonal curves are represented using **polynomial coefficients**. These coefficients define the shape of the demand curve for that particular season. For example, a polynomial may contain terms such as:

$$
ax^2 + bx + c
$$

where the coefficients determine the shape of the curve.

The resulting curve represents a stylized **24-hour demand fraction profile**, with the demand fraction ranging approximately from:

$$
0 \leq DemandFraction \leq 1
$$

A value closer to **0** represents a lower portion of the demand profile, while a value closer to **1** represents a higher portion of the demand profile.

Because each season has its own polynomial coefficients, RANCOR can represent different demand patterns for **winter, spring, summer, and fall** throughout the simulated day.

#### **3.2.2.1.2 Building the Demand Schedule**

Once the **24-hour season curve** is created, RANCOR samples points along the curve to build the demand schedule used during the trial.

The number of sampling points is determined by:

$$
Splits = NumGridDemandChanges + 1
$$

These points are **evenly spaced across the 24-hour curve**. At each point, RANCOR samples the demand fraction from the seasonal curve and adds that value to a collection. Together, these sampled values create the demand schedule for the trial.

The **NumGridDemandChanges** setting controls how many distinct demand changes occur throughout the trial.

* **Fewer demand changes** result in fewer samples and larger steps between demand levels.
* **More demand changes** result in finer sampling of the seasonal curve and smaller steps between demand levels.

In simple terms, increasing **NumGridDemandChanges** allows the demand schedule to follow the shape of the seasonal curve more closely.

#### **3.2.2.1.3 Timestep Cadence**

The **timestep cadence** determines how much simulated time passes between changes in grid demand.

RANCOR takes the queued demand values created from the season curve and spreads them evenly across the total trial length. The spacing between demand changes is determined by the **TrialLength** and the number of grid demand changes.

The demand schedule contains:

$$
NumGridDemandChanges + 1
$$

queued demand values distributed throughout the trial.

This means that increasing the number of demand changes creates **more frequent, smaller changes**, while decreasing the number creates **less frequent, larger changes**.

##### **Per-Unit Demand**

For each reactor unit, RANCOR calculates demand using:

$$
Demand_{unit}
=
\frac{
60\text{ MW}
\times
\operatorname{clamp}(Fraction + Noise,\ 0,\ 1)
}{
60
}
$$

The calculation assumes a **60 MW reactor for each unit**.

A random noise value is also added to each unit:

$$
-0.05 \leq Noise \leq 0.05
$$

This provides a small amount of variation between units so that they do not all follow identical demand values.

The `clamp` limits the combined fraction and noise value to between **0 and 1**.

##### **Fleet Grid Demand**

After demand is calculated for each individual unit, the values are added together to determine the total fleet **GridDemand**:

$$
GridDemand = \sum Demand_{unit}
$$

This represents the combined grid demand across all units in the simulation.

##### **Trial Time**

An important distinction is that **TrialTime does not increase during every dispatcher tick**.

TrialTime increases only once every **10 dispatcher ticks**, based on:

```text
counter % 10 == 0
```

This mapping is **hard-coded** and cannot currently be changed through the scenario settings.

#### **3.2.2.1.4 How to Change It**

The configurable parts of the demand schedule are controlled through scenario/settings JSON fields.

| Setting                | Effect                                                                                                                                                              |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `TrialLength`          | Controls the total simulation duration. Together with `NumGridDemandChanges`, it determines the spacing between demand changes.                                     |
| `NumGridDemandChanges` | Controls how many times demand changes throughout the trial and how finely the season curve is sampled. A higher value creates more frequent, smaller demand steps. |
| `GridDemandFraction`   | Multiplies the sampled curve value before it is scaled to MW. This controls the overall magnitude of demand. For example, `0.8` represents 80% of the curve's peak. |
| `Season`               | Selects the winter, spring, summer, or fall polynomial used to shape the 24-hour demand curve.                                                                      |

In summary:

* To change **how frequently demand changes**, adjust `TrialLength` and/or `NumGridDemandChanges`.
* To change the **overall demand magnitude**, adjust `GridDemandFraction`.
* To change the **shape of the demand curve**, adjust `Season`.

!!! note "Hard-Coded Values"
    The **±0.05 per-unit random noise**, **60 MW per-unit assumption**, and the mapping that increments TrialTime once every **10 dispatcher ticks** are hard-coded. Changing these values requires a code change rather than a scenario/settings change.

