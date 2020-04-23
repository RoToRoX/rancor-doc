# Welcome to the high stakes world of simulated nuclear reactors!
In all seriousness, the Rancor microworld is a cutting edge tool for performing quick testing of novel HMI systems related to nuclear power and can be a very potent method to validate your research. 

Included in this section oAny experiment has some primary aspects that underpin your design and frame your research question. This section will breakdown the common aspects of an experiment using the Rancor microworld. 

A Rancor experiment has the following primary components:
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