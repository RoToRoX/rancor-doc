# Rancor Overview
The Rancor microworld simulates a simplified nuclear process comprised of a nuclear reactor core that provides the heat source for gamified water-based Rankine cycle simulation. In fact, the name Rancor, bestowed upon the microworld, was formed by combining the first part of the term Rankine with an abbreviation of the term core to denote a nuclear reactor core as the boiler within the Rankine cycle. 

## Gamified Thermohydraulic Simulation

The Rancor microworld is based upon a **water-based Rankine cycle**, which is a mathematical model describing the energy and associated phase changes of a fluid to vapor to convert the thermal energy from the steam into mechanical energy used to spin a turbine and generate electricity. The underlying thermohydraulic simulation in the Rancor microworld diverges from a general water-based Rankine cycle in order to simplify the system in accordance with the
principles of gamification.

The thermohydraulics of the simulation is roughly approximated by the design specifications of a **small modular reactor**. The model conserves mass and enthalpy. The core heating and enthalpy losses use difference equations and are parameterized using realistic units. The state change and flow dynamics are largely gamified with little to no fidelity beyond conserving mass. On the primary side, natural circulation increases monotonically with temperature. Turning on reactor coolant pumps increases flow. The steam generators are implemented such that the water level on the secondary side determines the generator’s efficiency. Participants are incentivized to 

## Use Cases
The Rancor microworld serves to perform rapid prototyping and human factors testing of novel control room design concepts due its reduced scale and ease of developing new components. Use of the microworld is primarily intended for research purposes and to support the continued development of modern, digital reactor control interfaces. The microworld gives researchers and designers a broad selection of faults, manipulations, and process modifications to test against and develop an understanding of what impacts a participant's ability to successfully operate the microworld. 

### Copyright
Copyright in software entitled, “RANCOR Microworld Simulation Environment for Nuclear Process Control”, copyright assertion extension granted by DOE to BEA on 9/27/18, for a period of ten (10) years, having BEA Attorney Docket No. CW-18-08.