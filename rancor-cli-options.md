## Rancor (WPF) Command-Line Options

**Usage**  
```powershell
.\Rancor.exe [options]
```

| Short | Long           | Arg Name        | Type    | Required | Default | Description                                                                                         |
|:-----:|:--------------:|:----------------|:--------|:--------:|:-------:|:----------------------------------------------------------------------------------------------------|
| `-c`  | `--config`     | `layoutfile`    | string  | No       | ―       | Window layout file path (relative to application dir)                                               |
| `-p`  | `--p3`         | `p3inifile`     | string  | No       | ―       | CBP config file path (relative to application dir)                                                 |
| `-s`  | `--scenario`   | `scenariofile`  | string  | No       | ―       | Scenario file path (relative to application dir)                                                    |
| `-x`  | `--settings`   | `settingsfile`  | string  | No       | ―       | Settings file (participant ID, variables, timing); path relative to app dir                         |
| `-r`  | `--participant`| `participantID` | string  | No       | ―       | Override participant ID                                                                             |
| `-w`  | `--webapi`     | `webApiFile`    | string  | No       | ―       | Web API config file (server/client); path relative to app dir                                        |
| `-h`  | `--hunter`     | `hunterFile`    | string  | No       | ―       | Optional Hunter file; path relative to application dir                                              |
| `-l`  | `--headless`   | `headless`      | bool    | No       | false   | Run without GUI (headless); ignores layout file                                                     |
| `-g`  | `--gpwr`       | `gpwrVmConfig`  | string  | No       | ―       | GPWR-specific ViewModel config; ignored for regular GPWR                                            |

---

### Windows Batch Example

Save this as `launch_startup.bat` in your `Application` folder and double-click to run:

```bat
@echo off
cd /d "%~dp0"
Rancor.exe --headless ^
            --settings Config\Settings\dev-settings.json ^
            --scenario Config\Scenarios\Normal\Scn2_Startup_MOL.json
```
