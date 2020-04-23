# Welcome to the high stakes world of simulated nuclear reactors!

In all seriousness, the Rancor microworld is a cutting edge tool for performing quick testing of novel HMI systems related to nuclear power and can be a very potent method to validate your research. 

### Table of Contents

* [Scenario Design](https://github.com/rogerlew/rancor-release/wiki/Experimenter-Guide#scenario-design)
* [General Use Cases and Terms](https://github.com/rogerlew/rancor-release/wiki/Experimenter-Guide#general-use-cases-and-terms)
* [Scenario Authoring](https://github.com/rogerlew/rancor-release/wiki/Experimenter-Guide#scenario-authoring)
* [Model Parameters](https://github.com/rogerlew/rancor-release/wiki/Experimenter-Guide#model-parameters)
* [Simulator Outputs](https://github.com/rogerlew/rancor-release/wiki/Experimenter-Guide#simulator-outputs)

# Scenario Design

An experiment has some primary aspects that underpin your design and frame your research question. This section will breakdown the common aspects of an experiment using the Rancor microworld. 

A Rancor experiment has the following primary features:
- Time
- Plant states
- Faults
- Procedures

### Time
This factor is the time of the study or experimental session that your participant will experience (endure?). This can be set to any time in seconds and should align with your overall experimental design. It is important to test this with the scenarios and procedures you have in mind to ensure that your chosen time scale gives your participant sufficient time to complete the steps needed for your experiment.

### Plant States
These are loaded with default values by the developers to ensure the system will actually launch and the simulation will be stable, at least for a little while. However, a large number of parameters can be modified if you require a different starting position or starting plant context for your study. Please see the [dictionary of parameters](https://github.com/rogerlew/rancor-release/wiki/Dictionary-of-parameter-terms) for more detailed information on those options.

### Faults
These are the primary independent variables for Rancor microworld studies. This is where the primary experimental manipulation will be. These faults are defined by a set of control actions or changes to the simulation values and a time or condition-based trigger. This enables the researcher to force users into various situations outside of a standard steady-state operation. These abnormal or emergency scenarios are frequently accompanied by procedures to help guide the participant through the instance.

### Procedures
Procedures are designed to be a tool or resource for the participant to successfully navigate the scenario. However, procedures may also be an area of research or manipulation for the study. Please note that currently procedures have to be opened and interacted with outside of the Rancor microworld. There is currently not a computer-based procedure system for the Rancor microworld.

The Rancor microworld is a simplified nuclear reactor simulation platform designed to be a more accessible means of performing research on modern, digital reactor human-machine interface systems. By greatly reducing the number of critical parameters, the microworld can allow for quick iterations and changes to reactor HMIs and advancement of those designs.

# General Use Cases and Terms

## Use cases
The platform has been used to assess situational awareness, learnability, different control schemes, overviews, alarm systems, and more. The high level of configurability and malleability of the system allows for increases to potential experimental models and research questions. 

## Terms
Throughout this wiki and research documents published using the Rancor microworld you will see some frequently used terms that we want to define here. 
- Scenario: This one is a very frequently used term. A scenario is the set of rules, parameters, faults, variables, or manipulations that your experiment may use. These 'settings' for lack of a better term are dynamic and can be tweaked to suit your research needs. 
- Procedure: As this is a child of nuclear power and the simulators in that industry there are a set of procedures that you will use to guide your participants to their goal. While you can use the microworld without a procedure, it may prove extremely difficult to manage the parameters and systems on the fly. When we use the term procedure we truly do mean a step by step guide on manipulating the reactor to the desired end goal of the scenario.
- P&ID: A P&ID is also known as a piping and instrumentation diagram and serves as a model of the system. When launched in the standard mode it is the window on the top right of your screen.
- Radar plot: This is the spoke-and-wheel looking overview object on the left of the default launched program. This is a configurable visualization that serves to show several different variables of interest in an effort to create a visually salient shape that can be associated with a given plant state.
- Trip: When we talk about a reactor trip or you see the 'Trip reactor' button this is very similar to tripping a breaker in your home. When you trip a nuclear reactor you are throwing a switch which actuated the control rods to halt the nuclear fission reaction in the core. Trips are safety-driven actions and can have large operational and financial impacts in the nuclear power industry.
- INI file: Pronounced eye-en-eye file. These are files in the configuration folder within the Executables folder. Currently these are the way we adjust settings in the Rancor simulator, such as screen size, radar plot characteristics, colors, etc. Colors are required to be in hexadecimal or color name formats.
- Auto/Manual: These terms are fairly obvious, however it doesn't hurt to explain what these mean in the context of a Rancor experiment. Auto will perform control actions in response to the simulation and various critical parameters. This will only maintain a steady state unless you have enacted a set goal (60% power) then it will navigate to that according to its own logic. By the inverse manual requires input from the participant to affect change in the given system and the participant will be required to respond to the changes in states and system contexts.

# Scenario Authoring

Scenarios can be authored using the Setup.exe program provided with Rancor.

# Model Parameters

The model contains several parameters or "points" to keep track of the system states. The scenario files define the initial conditions of the model states as well as fault conditions. This table provides a description for most of the model parameters.

| Point               | Description                                         | Value (Range)         |
| ------------------- |:---------------------------------------------------:| ---------------------:|
| TimeMultiplier      | Used by the model to control the speed of the model | 0.05                  |
| ModeValue           | integer specifying the state of the plant           | 0= Shutdown,          |
|                     |                                                     | 1= Reactor Startup,   |
|                     |                                                     | 2= Ready To Roll,     |
|                     |                                                     | 3= Turbine Rollup,    |
|                     |                                                     | 4= Ready to Sync.,    |
|                     |                                                     | 5= Online,            |
|                     |                                                     | 9= Unknown            |
| ControlsActive      | Operator can manipulate the controls                | true                  |

# Simulator Outputs

For each trial the simulator will produce two output files. One output is a spreadsheet (.csv) file with the time series of the model parameters at each timestep of the model. In addition to the time series output an event log is produced as a .json file. The event log contains operator actions as well as system events like reactor scrams.
