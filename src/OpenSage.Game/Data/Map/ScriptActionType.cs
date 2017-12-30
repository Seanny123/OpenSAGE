﻿namespace OpenSage.Data.Map
{
    // TODO: BFME re-used existing ScriptActionType values, so we can't have one enum for all SAGE games.
    // We can either have separate enums per game, or rely in InternalName, but this wasn't available in some
    // earlier Generals maps.
    public enum ScriptActionType : uint
    {
        DebugMessageBox = 0,
        SetFlag = 1,
        SetCounter = 2,
        Victory = 3,
        Defeat = 4,
        NoOp = 5,
        SetTimer = 6,
        PlaySoundEffect = 7,
        EnableScript = 8,
        DisableScript = 9,
        CallSubroutine = 10,
        PlaySoundEffectAt = 11,
        DamageMembersOfTeam = 12,
        MoveTeamTo = 13,
        MoveCameraTo = 14,
        IncrementCounter = 15,
        DecrementCounter = 16,
        MoveCameraAlongWaypointPath = 17,
        RotateCamera = 18,
        ResetCamera = 19,
        SetMillisecondTimer = 20,
        CameraModFreezeTime = 21,
        SetVisualSpeedMultiplier = 22,
        CreateObject = 23,
        SuspendBackgroundSounds = 24,
        ResumeBackgroundSounds = 25,
        CameraModSetFinalZoom = 26,
        CameraModSetFinalPitch = 27,
        CameraModFreezeAngle = 28,
        CameraModSetFinalSpeedMultiplier = 29,
        CameraModSetRollingAverage = 30,
        CameraModFinalLookToward = 31,
        CameraModLookToward = 32,
        TeamAttackTeam = 33,
        CreateReinforcementTeam = 34,
        MoveCameraToSelection = 35,
        TeamFollowWaypoints = 36,
        TeamSetState = 37,
        MoveNamedUnitTo = 38,
        NamedAttackNamed = 39,
        CreateNamedOnTeamAtWaypoint = 40,
        CreateUnnamedOnTeamAtWaypoint = 41,
        NamedApplyAttackPrioritySet = 42,
        TeamApplyAttackPrioritySet = 43,
        SetBaseConstructionSpeed = 44,
        NamedSetAttitude = 45,
        TeamSetAttitude = 46,
        NamedAttackArea = 47,
        NamedAttackTeam = 48,
        TeamAttackArea = 49,
        TeamAttackNamed = 50,
        TeamLoadTransports = 51,
        NamedEnterNamed = 52,
        TeamEnterNamed = 53,
        NamedExitAll = 54,
        TeamExitAll = 55,
        NamedFollowWaypoints = 56,
        NamedGuard = 57,
        TeamGuard = 58,
        NamedHunt = 59,
        TeamHunt = 60,
        PlayerSellEverything = 61,
        PlayerDisableBaseConstruction = 62,
        PlayerDisableFactories = 63,
        PlayerDisableUnitConstruction = 64,
        PlayerEnableBaseConstruction = 65,
        PlayerEnableFactories = 66,
        PlayerEnableUnitConstruction = 67,
        CameraMoveHome = 68,
        BuildTeam = 69,
        NamedDamage = 70,
        NamedDelete = 71,
        TeamDelete = 72,
        NamedKill = 73,
        TeamKill = 74,
        PlayerKill = 75,
        DisplayText = 76,
        CameoFlash = 77,
        NamedFlash = 78,
        TeamFlash = 79,
        MoviePlayFullScreen = 80,
        MoviePlayRadar = 81,
        SoundPlayNamed = 82,
        SpeechPlay = 83,
        PlayerTransferOwnershipPlayer = 84,
        NamedTransferOwnershipPlayer = 85,
        PlayerRelatesPlayer = 86,
        RadarCreateEvent = 87,
        RadarDisable = 88,
        RadarEnable = 89,
        MapRevealAtWaypoint = 90,
        TeamAvailableForRecruitment = 91,
        TeamCollectNearbyForTeam = 92,
        TeamMergeIntoTeam = 93,
        DisableInput = 94,
        EnableInput = 95,
        PlayerHunt = 96,
        SoundAmbientPause = 97,
        SoundAmbientResume = 98,
        MusicSetTrack = 99,
        SetTreeSway = 100,
        DebugString = 101,
        MapRevealAll = 102,
        TeamGarrisonSpecificBuilding = 103,
        ExitSpecificBuilding = 104,
        TeamGarrisonNearestBuilding = 105,
        TeamExitAllBuildings = 106,
        NamedGarrisonSpecificBuilding = 107,
        NamedGarrisonNearestBuilding = 108,
        NamedExitBuilding = 109,
        PlayerGarrisonAllBuildings = 110,
        PlayerExitAllBuildings = 111,
        TeamWander = 112,
        TeamPanic = 113,
        SetupCamera = 114,
        CameraLetterboxBegin = 115,
        CameraLetterboxEnd = 116,
        ZoomCamera = 117,
        PitchCamera = 118,
        CameraFollowNamed = 119,
        OversizeTerrain = 120,
        CameraFadeAdd = 121,
        CameraFadeSubtract = 122,
        CameraFadeSaturate = 123,
        CameraFadeMultiply = 124,
        CameraBwModeBegin = 125,
        CameraBwModeEnd = 126,
        DrawSkyboxBegin = 127,
        DrawSkyboxEnd = 128,
        SetAttackPriorityThing = 129,
        SetAttackPriorityKindOf = 130,
        SetDefaultAttackPriority = 131,
        CameraStopFollow = 132,
        CameraMotionBlur = 133,
        CameraMotionBlurJump = 134,
        CameraMotionBlurFollow = 135,
        CameraMotionBlurEndFollow = 136,
        FreezeTime = 137,
        UnfreezeTime = 138,
        ShowMilitaryCaption = 139,
        CameraSetAudibleDistance = 140,
        SetStoppingDistance = 141,
        NamedSetStoppingDistance = 142,
        SetFpsLimit = 143,
        MusicSetVolume = 144,
        MapShroudAtWaypoint = 145,
        MapShroudAll = 146,
        SetRandomTimer = 147,
        SetRandomMillisecondTimer = 148,
        StopTimer = 149,
        RestartTimer = 150,
        AddToMSecTimer = 151,
        SubFromMSecTimer = 152,
        TeamTransferToPlayer = 153,
        PlayerSetMoney = 154,
        PlayerGiveMoney = 155,
        DisableSpecialPowerDisplay = 156,
        EnableSpecialPowerDisplay = 157,
        NamedHideSpecialPowerDisplay = 158,
        NamedShowSpecialPowerDisplay = 159,
        DisplayCountownTimer = 160,
        HideCountdownTimer = 161,
        EnableCountdownTimerDisplay = 162,
        DisableCountdownTimerDisplay = 163,
        NamedStopSpecialPowerCountdown = 164,
        NamedStartSpecialPowerCountdown = 165,
        NamedSetSpecialPowerCountdown = 166,
        NamedAddSpecialPowerCountdown = 167,
        NamedFireSpecialPowerAtWaypoint = 168,
        NamedFireSpecialPowerAtNamed = 169,
        RefreshRadar = 170,
        CameraTetherNamed = 171,
        CameraStopTetherNamed = 172,
        CameraSetDefault = 173,
        NamedStop = 174,
        TeamStop = 175,
        TeamStopAndDisband = 176,
        RecruitTeam = 177,
        TeamSetOverrideRelationToTeam = 178,
        TeamRemoveOverrideRelationToTeam = 179,
        TeamRemoveAllOverrideRelations = 180,
        CameraLookTowardObject = 181,
        NamedFireWeaponFollowingWaypointPath = 182,
        TeamSetOverrideRelationToPlayer = 183,
        TeamRemoveOverrideRelationToPlayer = 184,
        PlayerSetOverrideRelationToTeam = 185,
        PlayerRemoveOverrideRelationToTeam = 186,
        UnitExecuteSequentialScript = 187,
        UnitExecuteSequentialScriptLooping = 188,
        UnitStopSequentialScript = 189,
        TeamExecuteSequentialScript = 190,
        TeamExecuteSequentialScriptLooping = 191,
        TeamStopSequentialScript = 192,
        UnitGuardForFrameCount = 193,
        UnitIdleForFrameCount = 194,
        TeamGuardForFrameCount = 195,
        TeamIdleForFrameCount = 196,
        WaterChangeHeight = 197,
        NamedUseCommandButtonAbilityOnNamed = 198,
        NamedUseCommandButtonAbilityAtWaypoint = 199,
        WaterChangeHeightOverTime = 200,
        MapSwitchBorder = 201,
        TeamGuardPosition = 202,
        TeamGuardObject = 203,
        TeamGuardArea = 204,
        ObjectForceSelect = 205,
        CameraLookTowardWaypoint = 206,
        UnitDestroyAllContained = 207,
        RadarForceEnable = 208,
        RadarRevertToNormal = 209,
        ScreenShake = 210,
        TechTreeModifyBuildabilityObject = 211,
        WarehouseSetValue = 212,
        ObjectCreateRadarEvent = 213,
        TeamCreateRadarEvent = 214,
        DisplayCinematicText = 215,
        SoundDisableType = 217,
        SoundEnableType = 218,
        SoundEnableAll = 219,
        AudioOverrideVolumeType = 220,
        DebugCrashBox = 216,
        AudioRestoreVolumeType = 221,
        AudioRestoreVolumeAllType = 222,
        InGamePopupMessage = 223,
        SetCaveIndex = 224,
        NamedSetHeld = 225,
        NamedSetToppleDirection = 226,
        UnitMoveTowardsNearestObjectType = 227,
        TeamMoveTowardsNearestObjectType = 228,
        MapRevealAllPerm = 229,
        MapRevealAllUndoPerm = 230,
        NamedSetRepulsor = 231,
        TeamSetRepulsor = 232,
        TeamWanderInPlace = 233,
        TeamIncreasePriority = 234,
        TeamDecreasePriority = 235,
        DisplayCounter = 236,
        HideCounter = 237,
        TeamUseCommandButtonAbilityOnNamed = 238,
        TeamUseCommandButtonAbilityAtWaypoint = 239,
        NamedUseCommandButtonAbility = 240,
        TeamUseCommandButtonAbility = 241,
        NamedFlashWhite = 242,
        TeamFlashWhite = 243,
        SkirmishBuildBuilding = 244,
        SkirmishFollowApproachPath = 245,
        IdleAllUnits = 246,
        ResumeSupplyTrucking = 247,
        NamedCustomColor = 248,
        SkirmishMoveToApproachPath = 249,
        SkirmishBuildBaseDefenseFront = 250,
        SkirmishFireSpecialPowerAtMostCost = 251,
        Placeholder_252 = 252,
        PlayerRepairNamedStructure = 253,
        SkirmishBuildBaseDefenseFlank = 254,
        SkirmishBuildStructureFront = 255,
        SkirmishBuildStructureFlank = 256,
        SkirmishAttackNearestGroupWithValue = 257,
        SkirmishPerformCommandButtonOnMostValuableObject = 258,
        SkirmishWaitForCommandButtonAvailableAll = 259,
        SkirmishWaitForCommandButtonAvailablePartial = 260,
        TeamSpinForFrameCount = 261,
        TeamAllUseCommandButtonOnNamed = 262,
        TeamAllUseCommandButtonOnNearestEnemyUnit = 263,
        TeamAllUseCommandButtonOnNearestGarrisonedBuilding = 264,
        TeamAllUseCommandButtonOnNearestKindOf = 265,
        TeamAllUseCommandButtonOnNearestEnemyBuilding = 266,
        TeamAllUseCommandButtonOnNearestEnemyBuildingClass = 267,
        TeamAllUseCommandButtonOnNearestObjectType = 268,
        TeamPartialUseCommandButton = 269,
        TeamCaptureNearestUnownedFactionUnit = 270,
        PlayerCreateTeamFromCapturedUnits = 271,
        PlayerAddSkillPoints = 272,
        PlayerAddRankLevel = 273,
        PlayerSetRankLevel = 274,
        PlayerSetRankLevelLimit = 275,
        PlayerGrantScience = 276,
        PlayerPurchaseScience = 277,
        TeamHuntWithCommandButton = 278,
        TeamWaitForNotContainedAll = 279,
        TeamWaitForNotContainedPartial = 280,
        TeamFollowWaypointsExact = 281,
        NamedFollowWaypointsExact = 282,
        TeamSetEmoticon = 283,
        NamedSetEmoticon = 284,
        AiPlayerBuildSupplyCenter = 285,
        AiPlayerBuildUpgrade = 286,
        ObjectListAddObjectType = 287,
        ObjectListRemoveObjectTye = 288,
        MapRevealPermanentlyAtWaypoint = 289,
        MapUndoRevealPermanentlyAtWaypoint = 290,
        NamedSetStealthEnabled = 291,
        TeamSetStealthEnabled = 292,
        EvaSetEnabledDisabled = 293,
        OptionsSetOcclusionMode = 294,
        LocalDefeat = 295,
        OptionsSetDrawIconUiMode = 296,
        OptionsSetPartialCapMode = 297,
        PlayerScienceAvailability = 298,
        UnitAffectObjectPanelFlags = 299,
        TeamAffectObjectPanelFlags = 300,
        PlayerSelectSkillSet = 301,
        ScriptingOverrideHulkLifetime = 302,
        NamedFaceNamed = 303,
        NamedFaceWaypoint = 304,
        TeamFaceNamed = 305,
        TeamFaceWaypoint = 306,
        CommandBarRemoveButtonObjectType = 307,
        CommandBarAddButtonObjectTypeSlot = 308,
        UnitSpawnNamedLocationOrientation = 309,
        PlayerAffectReceivingExperience = 310,
        PlayerExcludeFromScoreScreen = 311,
        TeamGuardSupplyCenter = 312,
        EnableScoring = 313,
        DisableScoring = 314,
        SoundSetVolume = 315,
        SpeechSetVolume = 316,
        DisableBorderShroud = 317,
        EnableBorderShroud = 318,
        ObjectAllowBonuses = 319,
        SoundRemoveAllDisabled = 320,
        SoundRemoveType = 321,
        TeamGuardInTunnelNetwork = 322,
        QuickVictory = 323,
        SetInfantryLightingOverride = 324,
        ResetInfantryLightingOverride = 325,
        TeamDeleteLiving = 326,
        ResizeViewGuardBand = 327,
        DeleteAllUnmanned = 328,
        ChooseVictimAlwaysUsesNormal = 329,
        CameraEnableSlaveMode = 330,
        CameraDisableSlaveMode = 331,
        CameraAddShakerAt = 332,
        SetTrainHeld = 333,
        NamedSetEvacLeftOrRight = 334,
        EnableObjectSound = 335,
        DisableObjectSound = 336,
        NamedUseCommandButtonAbilityUsingWaypointPath = 337,
        NamedSetUnmannedStatus = 338,
        TeamSetUnmannedStatus = 339,
        NamedSetBoobytrapped = 340,
        TeamSetBoobytrapped = 341,
        ShowWeather = 342,
        AiPlayerBuildTypeNearestTeam = 343,

        // Added in BFME
        HideUI = 347,
        ShowUI = 348,
        TeamGiveExperienceLevel = 355,
        TeamGiveExperiencePoints = 356,
        TeamSetExperiencePoints = 357,
        UnitGiveExperienceLevel = 358,
        UnitGiveExperiencePoints = 359,
        UnitSetExperiencePoints = 360,
        LivingWorldExitToRegionView = 366,
        PlayMovieInGame = 368,
        SetCounterToCounter = 372,
        SetRandomCounter = 373,
        SetCounterToCounter2 = 374, // Dupe of 372?
        SetUnitReference = 376,
        SetTeamReference = 377,
        SetUnitReferenceToReference = 378,
        NamedBaseUnpack = 381,
        BuildBaseBuilding = 383,
        BuildBaseBuildingInSlot = 384,
        BuildBaseBuildingPerTacticalMarker = 385,
        BuildBuildingOnFoundation = 386,
        AllowDisallowOneBuilding = 387,
        TeamMoveToNearestObjectOfKindOf = 391,
        TeamMoveToNearestObjectOfKindOfOwnedByPlayer = 392,
        TeamMoveToNearestObjectOfType = 393,
        TeamMoveToNearestObjectOfTypeOwnedByPlayer = 394,
        CounterMathCounter = 395,
        CounterMathValue = 396,
        TeamRecruitUnits = 397,
        TeamRecruitUnitsFromTeam = 398,
        TeamGuardTeam = 399,
        TeamGuardNearestKindOf = 400,
        UnitGuardNearestKindOf = 401,
        TeamUpgrade = 403,
        SetPlayerMoneyToCounter = 404,
        SetUnitExperienceToCounter = 406,
        SetPlayerCommandPointsUsedToCounter = 407,
        SetPlayerCommandPointsAvailableToCounter = 408,
        SetPlayerCommandPointsTotalToCounter = 409,
        UnitIdleForSeconds = 412,
        TeamGuardForSeconds = 413,
        TeamIdleForSeconds = 414,
        AudioFadeVolume = 417,
        ToggleAutoBuild = 418,
        GivePlayerUpgrade = 419,
        SetPlayerKillsOfKindOfToCounter = 421,
        SetPlayerOwnershipOfTypeCounter = 422,
        TeamSetHealth = 423,
        NamedUseCommandButtonOnNearestEnemyUnit = 424,
        NamedUseCommandButtonOnNearestObjectType = 429,
        ReinforcementsDisplayBanner = 430,
        TeamSetModelConditionForDuration = 435,
        KillHordeMembers = 436,
        SetCounterToUnitThread = 439,
        SetCounterToTeamThreat = 440,
        AudioMakeSoundImmuneToFade = 441,
        AudioMakeAllSoundsSubjectToFade = 443,
        CreateReinforcementTeamAtUnitPosition = 444,
        FireSpecialPowerOnNearestObjectType = 445,
        FireSpecialPowerOnNearestObjectTypeByPlayer = 446,
        FireSpecialPowerOnTeam = 447,
        AudioSetReverbRoomType = 448,
        AudioPushMusic = 450,
        AudioPopMusic = 451,
        UnitGuardPosition = 452,
        UnitGuardArea = 454,
        MoveTeamHome = 455,
        MusicScriptSetTrack = 456,
        MusicScriptPopMusic = 458,
        MusicReturnToMusicScripting = 460,
        TeamSetPlayersNearestUnitOfTypeToReference = 462,
        GateOpen = 463,
        GateClose = 464,
        DeployNamedSiegeOnWaypoint = 465,
        DeploySiegeOnWaypoint = 466,
        DeploySiegeNearTeam = 467,
        TeamHarvest = 468,
        MusicPlayTrackFiniteTimes = 471,
        MusicPushTrackFiniteTimesAndNotify = 474,
        MusicScriptPlayTrackFiniteTimesAndNotify = 476,
        MusicScriptPushTrackFiniteTimesAndNotify = 478,
        NameSetAutoAbility = 481,
        TeamSetAutoAbility = 482,
        SetLogicFogState = 483,
        CameraRestrictToArea = 484,
        CameraRemoveAreaRestriction = 485,
        UnitGuardAreaFromPosition = 486,
        TeamGuardAreaFromPosition = 487,
        FindHomeBaseOfPlayer = 488,
        UpgradeNearestWall = 489,
        TeamSetCustomState = 490,
        SetRefToNearestTeamOfTypeOwnedByPlayer = 491,
        NamedBaseUnpackFree = 492,
        SellBuildingOnFoundation = 493,
        GateReady = 496,
        TeamNeedsOpenGate = 497,
        UnitSetTeam = 498,
        UnitStandGround = 499,
        TeamStandGround = 500,
        UnitTeleportToWaypoint = 501,
        TeamTeleportToWaypoint = 502,
        OverridePlayerCommandPoints = 503,
        SelectObject = 504,
        Deselect = 505,
        HumanImpassableArea = 506,
        SetCounterToClientRandomValue = 507,
        PlaySoundEffectAtTeam = 509,
        VictoryScreen = 510,
        HeroSelectButtonFlash = 511,
        TeamAssimilateWithFirstWalkOnArmy = 513,
        UnitAssimilateWithFirstWalkOnArmy = 514,
        EnableHouseColor = 517,
        TeamForceEmotion = 519,
        PlayerForceEmotion = 520,
        UnitGainLevel = 522,
        TeamGainLevel = 523,
        LockCameraAngleAndHeight = 527,
        RotateCameraToAngle = 528,
        ShowMissionObjective = 530,
        HideMissionObjective = 531,
        MarkMissionObjectiveCompleted = 532,
        MarkMissionObjectiveNotCompleted = 533,
        RecruitComboUnitsFromTeam = 534,
        UnitChangeObjectStatus = 535,
        TeamChangeObjectStatus = 536,
        RemoveReinforcementArmy = 538,
        PlayerAssimilateWithArmyByName = 539,
        TeamAssimilateWithArmyByName = 540,
        CallInReinforcementsWithoutMovie = 542,
    }
}
