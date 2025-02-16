# ASFEnhance

[![AutoBuild][workflow_b]][workflow] [![Codacy Badge][codacy_b]][codacy] [![release][release_b]][release] [![Download][download_b]][release] [![License][license_b]][license]

[中文说明](README.zh-CN.md)

> Extend the function of ASF, add several useful commands

> Require minimal version of ASF: 5.1.5.3

Post link: [https://keylol.com/t716051-1-1](https://keylol.com/t716051-1-1)

## New Commands

### Steam Winter Sale Command

> This set of command will be removed when the sale ends.

| Command                | Access     | Description                                                                                  |
| ---------------------- | ---------- | -------------------------------------------------------------------------------------------- |
| `VOTE [Bots] [AppIDs]` | `Operator` | Vote for The Steam Award (If APPID is missing or less then 10, plugin will vote random game) |
| `CHECKVOTE [Bots]`     | `Operator` | Check how many the bot voted                                                                 |

### Common Commands

| Command             | Shorthand | Access          | Description                                                      |
| ------------------- | --------- | --------------- | ---------------------------------------------------------------- |
| `KEY <Text>`        | `K`       | `Any`           | Extract keys from plain text                                     |
| `PROFILE [Bots]`    | `PF`      | `FamilySharing` | Get bot's profile infomation                                     |
| `STEAMID [Bots]`    | `SID`     | `FamilySharing` | Get bot's steamID                                                |
| `FRIENDCODE [Bots]` | `FC`      | `FamilySharing` | Get bot's friend code                                            |
| `COOKIES [Bots]`    | -         | `Master`        | Get bot's steam cookies(only for debug, don't leak your cookies) |
| `ASFENHANCE`        | `ASFE`    | `Any`           | Get the version of the ASFEnhance                                |

### Wishlist Commands

| Command                          | Shorthand | Access   | Description                     |
| -------------------------------- | --------- | -------- | ------------------------------- |
| `ADDWISHLIST [Bots] <AppIDs>`    | `AW`      | `Master` | Add game to bot's wishlist      |
| `REMOVEWISHLIST [Bots] <AppIDs>` | `RW`      | `Master` | Delete game from bot's wishlist |

### Store Commands

| Command                                    | Shorthand | Access     | Description                                                                         |
| ------------------------------------------ | --------- | ---------- | ----------------------------------------------------------------------------------- |
| `SUBS [Bots] <AppIDS\|SubIDS\|BundleIDS>`  | `S`       | `Operator` | Get available subs from store page, support `APP/SUB/BUNDLE`                        |
| `PUBLISHRECOMMENT [Bots] <AppIDS> COMMENT` | `PREC`    | `Operator` | Publish a recomment for game, if appID > 0 it will rateUp, or if appId < 0 rateDown |
| `DELETERECOMMENT [Bots] <AppIDS>`          | `DREC`    | `Operator` | Delete a recomment for game (Still have BUG, not working yet)                       |

### Cart Commands

> Steam saves cart information via cookies, restart bot instance will let shopping cart being emptied

| Command                              | Shorthand | Access     | Description                                                                    |
| ------------------------------------ | --------- | ---------- | ------------------------------------------------------------------------------ |
| `CART [Bots]`                        | `C`       | `Operator` | Get bot's cart information                                                     |
| `ADDCART [Bots] <SubIDs\|BundleIDs>` | `AC`      | `Operator` | Add game to bot's cart, only support `SUB/BUNDLE`                              |
| `CARTRESET [Bots]`                   | `CR`      | `Operator` | Clear bot's cart                                                               |
| `CARTCOUNTRY [Bots]`                 | `CC`      | `Operator` | Get bot's available currency area (Depends to wallet area and the IP location) |
| `SETCOUNTRY [Bots] <CountryCode>`    | `SC`      | `Operator` | Set bot's currency area (NOT WORKING, WIP)                                     |
| `PURCHASE [Bots]`                    | `PC`      | `Master`   | Purchase bot's items for it self                                               |

> Steam allows duplicate purchases, please check cart before using PURCHASE command.

## Shorthand Commands

| Shorthand              | Equivalent Command             | Description                    |
| ---------------------- | ------------------------------ | ------------------------------ |
| `AL [Bots] <Licenses>` | `ADDLICENSE [Bots] <Licenses>` | Add free `SUB`                 |
| `LA`                   | `LEVEL ASF`                    | Get All bot's level            |
| `BA`                   | `BALANCE ASF`                  | Get All bot's wallet balance   |
| `PA`                   | `POINTS ASF`                   | Get All bot's points balance   |
| `P [Bots]`             | `POINTS`                       | Get bot's points balance       |
| `CA`                   | `CART ASF`                     | Get All bot's cart information |

## Download Link

[Releases](https://github.com/chr233/ASFEnhance/releases)

[workflow_b]: https://github.com/chr233/ASFEnhance/actions/workflows/dotnet.yml/badge.svg
[workflow]: https://github.com/chr233/ASFEnhance/actions/workflows/dotnet.yml
[codacy_b]: https://app.codacy.com/project/badge/Grade/3d174e792fd4412bb6b34a77d67e5dea
[codacy]: https://www.codacy.com/gh/chr233/ASFEnhance/dashboard
[download_b]: https://img.shields.io/github/downloads/chr233/ASFEnhance/total
[release]: https://github.com/chr233/ASFEnhance/releases
[release_b]: https://img.shields.io/github/v/release/chr233/ASFEnhance
[license]: https://github.com/chr233/ASFEnhance/blob/master/license
[license_b]: https://img.shields.io/github/license/chr233/ASFEnhance
