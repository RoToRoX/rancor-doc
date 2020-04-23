Welcome to the Rancor wiki page. 

# Rancor Overview
The Rancor microworld simulates a simplified nuclear process comprised of a nuclear reactor core that provides the heat source for gamified water-based Rankine cycle simulation. In fact, the name Rancor, bestowed upon the microworld, was formed by combining the first part of the term Rankine with an abbreviation of the term core to denote a nuclear reactor core as the boiler within the Rankine cycle. 

The goal of Rancor is to support research operations in advanced and novel process control industries HMI design and human factors.

![Paper with Gear](https://github.com/rogerlew/rancor-release/blob/master/Rancor_wiki_icons/Setup.png)   [Getting Started](https://github.com/rogerlew/rancor-release/wiki/Getting-Started) - How to Install and Run Rancor

![Labcoat](https://github.com/rogerlew/rancor-release/blob/master/Rancor_wiki_icons/LabCoat.png)   [Experimenter Guide](https://github.com/rogerlew/rancor-release/wiki/Experimenter-Guide) - Information for researchers

## Simulator Description

The Rancor Microworld is a simplified nuclear power plant simulator. It represents the process of an integrated pressurized light water reactor core with a secondary Rankine cycle turbine/generator. The reactor core is governed by simplified core physics. Operators have the ability to raise and lower control rods to change the reactivity and consequently generate more or less electricity. The microworld provides a digital human machine interface for operating and monitoring the plant efficiently to maximize profits within the simulation.

A **water-based Rankine cycle**, is model describing the energy and associated phase changes of a fluid to vapor to convert the thermal energy from the steam into mechanical energy used to spin a turbine and generate electricity.

The thermohydraulics of the simulation is roughly approximated by the design specifications of a **small modular reactor**. The model conserves mass and enthalpy. The core heating and enthalpy losses use difference equations and are parameterized using realistic units. The state change and flow dynamics are largely gamified with little to no fidelity beyond conserving mass. On the primary side, natural circulation increases monotonically with temperature. Turning on reactor coolant pumps increases flow. The steam generators are implemented such that the water level on the secondary side determines the generator’s efficiency. Participants are incentivized to maximize efficiency of operating the plant by balancing efficiency with a gamified revenue calculation. 

For more information see the [Detailed Simulator Description](https://github.com/rogerlew/rancor-release/wiki/Detailed-Simulator-Description).

## Use Cases
The Rancor microworld serves to perform rapid prototyping and human factors testing of novel control room design concepts due its reduced scale and ease of developing new components. Use of the microworld is primarily intended for research purposes and to support the continued development of modern, digital reactor control interfaces. The microworld gives researchers and designers a broad selection of faults, manipulations, and process modifications to test against and develop an understanding of what impacts a participant's ability to successfully operate the microworld. 

### Copyright
Copyright in software entitled, "RANCOR Microworld Simulation Environment for Nuclear Process Control", copyright assertion extension granted by DOE to BEA on 9/27/18, for a period of ten (10) years, having BEA Attorney Docket No. CW-18-08.


