# Surface Tension
[![GitHub all releases](https://img.shields.io/github/downloads/Electro7777/Surface-Tension/total)]()

Currently being maintained by Heisenberg3666, originally made by Holmium67.

## Description
On detonation of the Alpha Warhead, radiation is emitted from the facility and will slowly kill the remaining people. All the times and announcements are configurable.

## Config Settings:
Config:
| Name       | Description                      | Default |
|------------|----------------------------------|---------|
| is_enabled | null                             | true    |
| debug_mode | Enable to help find bug sources. | false   |

### Damage Config:
| Name              | Description                                                                                                       | Default |
|-------------------|-------------------------------------------------------------------------------------------------------------------|---------|
| damage_delay      | This is the time (seconds) you want to delay the damage for. Set to -1 to disable. Minimum is 0.5, maximum is 300 | -1      |
| damage_scp        | This is the amount you want to damage SCPs by. Set to -1 to disable.                                              | 5       |
| damage_player     | This is the amount you want to damage players by. Set to -1 to disable.                                           | 1       |
| damage_interval   | This is the interval (seconds) that you want to damage players. Minimum is 0.5, maximum is 60                     | 1       |
| damage_is_percent | The type of damage done (HP or percentage of HP).                                                                 | false   |

### Announcement Config:
| Name              | Description                                                                                                        | Default |
|-------------------|--------------------------------------------------------------------------------------------------------------------|---------|
| announcement_type | This is the type of announcement that will be made. Options are: None (-1), Cassie (1), Hint (2) or Broadcast (4). | -1      |

#### Cassie Announcement Config:
| Name             | Description                                                                                                                   | Default                                                                                                          |
|------------------|-------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------|
| cassie_text      | This is the text that will be announced by Cassie.                                                                            | The under ground facility has been detonated . . . . Radiation has been detected . Please evacuate immediately . |
| cassie_subtitles | These are the subtitles for the Cassie announcement.                                                                          | The underground facility has been detonated. Radiation has been detected, please evacuate immediately.           |
| cassie_time      | This is the delay (seconds) before the Cassie announcement will be made. Set to -1 to disable. Minimum is 0.5, maximum is 300 | -1                                                                                                               |

#### Hint Announcement Config:
| Name      | Description                                                                                                            | Default                                                                                                               |
|-----------|------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------|
| hint_text | This is the text that will be displayed when announced.                                                                | The underground section of the facility has been detonated. Radiation has been detected, please evacuate immediately. |
| hint_time | This is the delay (seconds) before the announcement will be made. Set to -1 to disable. Minimum is 0.5, maximum is 300 | -1                                                                                                                    |

#### Broadcast Announcement Config:
| Name           | Description                                                                                                            | Default                                                                                                               |
|----------------|------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------|
| broadcast_text | This is the text that will be displayed when announced.                                                                | The underground section of the facility has been detonated. Radiation has been detected, please evacuate immediately. |
| broadcast_time | This is the delay (seconds) before the announcement will be made. Set to -1 to disable. Minimum is 0.5, maximum is 300 | -1                                                                                                                    |
