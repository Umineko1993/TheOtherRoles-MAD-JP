using System.Collections.Generic;
using UnityEngine;
using BepInEx.Configuration;
using System;
using System.Linq;
using HarmonyLib;
using Hazel;
using System.Reflection;
using System.Text;
using static TheOtherRoles.TheOtherRoles;

namespace TheOtherRoles {
	public class CustomOptionHolder {
		public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
		public static string[] presets = new string[]{ "プリセット 1", "プリセット 2", "プリセット 3", "プリセット 4", "プリセット 5" };

		public static CustomOption presetSelection;
		public static CustomOption activateRoles;
		public static CustomOption crewmateRolesCountMin;
		public static CustomOption crewmateRolesCountMax;
		public static CustomOption neutralRolesCountMin;
		public static CustomOption neutralRolesCountMax;
		public static CustomOption impostorRolesCountMin;
		public static CustomOption impostorRolesCountMax;

		public static CustomOption adminTimer;
		public static CustomOption enabledAdminTimer;
		public static CustomOption hideTaskOverlayOnSabMap;

		public static CustomOption mafiaSpawnRate;
		public static CustomOption janitorCooldown;

		public static CustomOption morphlingSpawnRate;
		public static CustomOption morphlingCooldown;
		public static CustomOption morphlingDuration;

		public static CustomOption camouflagerSpawnRate;
		public static CustomOption camouflagerCooldown;
		public static CustomOption camouflagerDuration;

		public static CustomOption evilHackerSpawnRate;
		public static CustomOption evilHackerCanCreateMadmate;
		public static CustomOption createdMadmateCanDieToSheriff;
		public static CustomOption createdMadmateCanEnterVents;
		public static CustomOption createdMadmateHasImpostorVision;
		public static CustomOption createdMadmateNoticeImpostors;
		public static CustomOption createdMadmateExileCrewmate;

		public static CustomOption vampireSpawnRate;
		public static CustomOption vampireKillDelay;
		public static CustomOption vampireCooldown;
		public static CustomOption vampireCanKillNearGarlics;

		public static CustomOption eraserSpawnRate;
		public static CustomOption eraserCooldown;
		public static CustomOption eraserCanEraseAnyone;

		public static CustomOption miniSpawnRate;
		public static CustomOption miniGrowingUpDuration;

		public static CustomOption loversSpawnRate;
		public static CustomOption loversImpLoverRate;
		public static CustomOption loversBothDie;
		public static CustomOption loversCanHaveAnotherRole;

		public static CustomOption guesserSpawnRate;
		public static CustomOption guesserIsImpGuesserRate;
		public static CustomOption guesserNumberOfShots;
		public static CustomOption guesserHasMultipleShotsPerMeeting;
		public static CustomOption guesserShowInfoInGhostChat;
		public static CustomOption guesserKillsThroughShield;

		public static CustomOption jesterSpawnRate;
		public static CustomOption jesterCanCallEmergency;

		public static CustomOption arsonistSpawnRate;
		public static CustomOption arsonistCooldown;
		public static CustomOption arsonistDuration;

		public static CustomOption jackalSpawnRate;
		public static CustomOption jackalKillCooldown;
		public static CustomOption jackalCreateSidekickCooldown;
		public static CustomOption jackalCanUseVents;
		public static CustomOption jackalCanCreateSidekick;
		public static CustomOption sidekickPromotesToJackal;
		public static CustomOption sidekickCanKill;
		public static CustomOption sidekickCanUseVents;
		public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
		public static CustomOption jackalCanCreateSidekickFromImpostor;
		public static CustomOption jackalAndSidekickHaveImpostorVision;

		public static CustomOption bountyHunterSpawnRate;
		public static CustomOption bountyHunterBountyDuration;
		public static CustomOption bountyHunterReducedCooldown;
		public static CustomOption bountyHunterPunishmentTime;
		public static CustomOption bountyHunterShowArrow;
		public static CustomOption bountyHunterArrowUpdateIntervall;

		public static CustomOption witchSpawnRate;
		public static CustomOption witchCooldown;
		public static CustomOption witchAdditionalCooldown;
		public static CustomOption witchCanSpellAnyone;
		public static CustomOption witchSpellCastingDuration;
		public static CustomOption witchTriggerBothCooldowns;
		public static CustomOption witchVoteSavesTargets;

		public static CustomOption shifterSpawnRate;
		public static CustomOption shifterShiftsModifiers;

		public static CustomOption mayorSpawnRate;

		public static CustomOption engineerSpawnRate;
		public static CustomOption engineerNumberOfFixes;
		public static CustomOption engineerHighlightForImpostors;
		public static CustomOption engineerHighlightForTeamJackal;

		public static CustomOption sheriffSpawnRate;
		public static CustomOption sheriffCooldown;
		public static CustomOption sheriffNumberOfShots;
		public static CustomOption sheriffCanKillNeutrals;

		public static CustomOption lighterSpawnRate;
		public static CustomOption lighterModeLightsOnVision;
		public static CustomOption lighterModeLightsOffVision;
		public static CustomOption lighterCooldown;
		public static CustomOption lighterDuration;

		public static CustomOption detectiveSpawnRate;
		public static CustomOption detectiveAnonymousFootprints;
		public static CustomOption detectiveFootprintIntervall;
		public static CustomOption detectiveFootprintDuration;
		public static CustomOption detectiveReportNameDuration;
		public static CustomOption detectiveReportColorDuration;

		public static CustomOption timeMasterSpawnRate;
		public static CustomOption timeMasterCooldown;
		public static CustomOption timeMasterRewindTime;
		public static CustomOption timeMasterShieldDuration;

		public static CustomOption medicSpawnRate;
		public static CustomOption medicShowShielded;
		public static CustomOption medicShowAttemptToShielded;
		public static CustomOption medicSetShieldAfterMeeting;
		public static CustomOption medicShowAttemptToMedic;

		public static CustomOption swapperSpawnRate;
		public static CustomOption swapperCanCallEmergency;
		public static CustomOption swapperCanOnlySwapOthers;

		public static CustomOption seerSpawnRate;
		public static CustomOption seerMode;
		public static CustomOption seerSoulDuration;
		public static CustomOption seerLimitSoulDuration;

		public static CustomOption hackerSpawnRate;
		public static CustomOption hackerCooldown;
		public static CustomOption hackerHackeringDuration;
		public static CustomOption hackerOnlyColorType;

		public static CustomOption trackerSpawnRate;
		public static CustomOption trackerUpdateIntervall;
		public static CustomOption trackerResetTargetAfterMeeting;
		public static CustomOption trackerCanTrackCorpses;
		public static CustomOption trackerCorpsesTrackingCooldown;
		public static CustomOption trackerCorpsesTrackingDuration;

		public static CustomOption snitchSpawnRate;
		public static CustomOption snitchLeftTasksForReveal;
		public static CustomOption snitchIncludeTeamJackal;
		public static CustomOption snitchTeamJackalUseDifferentArrowColor;

		public static CustomOption spySpawnRate;
		public static CustomOption spyCanDieToSheriff;
		public static CustomOption spyImpostorsCanKillAnyone;
		public static CustomOption spyCanEnterVents;
		public static CustomOption spyHasImpostorVision;

		public static CustomOption tricksterSpawnRate;
		public static CustomOption tricksterPlaceBoxCooldown;
		public static CustomOption tricksterLightsOutCooldown;
		public static CustomOption tricksterLightsOutDuration;

		public static CustomOption cleanerSpawnRate;
		public static CustomOption cleanerCooldown;
		
		public static CustomOption warlockSpawnRate;
		public static CustomOption warlockCooldown;
		public static CustomOption warlockRootTime;

		public static CustomOption securityGuardSpawnRate;
		public static CustomOption securityGuardCooldown;
		public static CustomOption securityGuardTotalScrews;
		public static CustomOption securityGuardCamPrice;
		public static CustomOption securityGuardVentPrice;

		public static CustomOption baitSpawnRate;
		public static CustomOption baitHighlightAllVents;
		public static CustomOption baitReportDelay;
		public static CustomOption baitShowKillFlash;

		public static CustomOption vultureSpawnRate;
		public static CustomOption vultureCooldown;
		public static CustomOption vultureNumberToWin;
		public static CustomOption vultureCanUseVents;
		public static CustomOption vultureShowArrows;

		public static CustomOption mediumSpawnRate;
		public static CustomOption mediumCooldown;
		public static CustomOption mediumDuration;
		public static CustomOption mediumOneTimeUse;

		public static CustomOption madmateSpawnRate;
		public static CustomOption madmateCanDieToSheriff;
		public static CustomOption madmateCanEnterVents;
		public static CustomOption madmateHasImpostorVision;
		public static CustomOption madmateNoticeImpostors;
		public static CustomOption madmateCommonTasks;
		public static CustomOption madmateShortTasks;
		public static CustomOption madmateLongTasks;
		public static CustomOption madmateExileCrewmate;

		public static CustomOption lawyerSpawnRate;
		public static CustomOption lawyerTargetKnows;
		public static CustomOption lawyerWinsAfterMeetings;
		public static CustomOption lawyerNeededMeetings;
		public static CustomOption lawyerVision;
		public static CustomOption lawyerKnowsRole;
		public static CustomOption pursuerCooldown;
		public static CustomOption pursuerBlanksNumber;

		public static CustomOption maxNumberOfMeetings;
		public static CustomOption blockSkippingInEmergencyMeetings;
		public static CustomOption noVoteIsSelfVote;
		public static CustomOption hidePlayerNames;
		public static CustomOption allowParallelMedBayScans;
		public static CustomOption dynamicMap;


		internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

		public static string cs(Color c, string s) {
			return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
		}
 
		private static byte ToByte(float f) {
			f = Mathf.Clamp01(f);
			return (byte)(f * 255);
		}

		public static void Load() {

			// Role Options
			presetSelection = CustomOption.Create(0, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "プリセット"), presets, null, true);
			activateRoles = CustomOption.Create(7, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Modの役職を有効にし、バニラの役職を無効にする"), true, null, true);

			// Using new id's for the options to not break compatibilty with older versions
			crewmateRolesCountMin = CustomOption.Create(300, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "乗組員役職 最小"), 0f, 0f, 15f, 1f, null, true);
			crewmateRolesCountMax = CustomOption.Create(301, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "乗組員役職 最大"), 0f, 0f, 15f, 1f);
			neutralRolesCountMin = CustomOption.Create(302, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "その他陣営役職 最小"), 0f, 0f, 15f, 1f);
			neutralRolesCountMax = CustomOption.Create(303, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "その他陣営役職 最大"), 0f, 0f, 15f, 1f);
			impostorRolesCountMin = CustomOption.Create(304, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "インポスター役職 最小"), 0f, 0f, 3f, 1f);
			impostorRolesCountMax = CustomOption.Create(305, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "インポスター役職 最大"), 0f, 0f, 3f, 1f);

			adminTimer = CustomOption.Create(99, "アドミンの利用可能時間", 10f, 0f, 120f, 1f);
			enabledAdminTimer = CustomOption.Create(98, "アドミンの時間制限を有効にする", true);
			hideTaskOverlayOnSabMap = CustomOption.Create(97, "妨害マップで偽の仕事を非表示にするか", false);

			mafiaSpawnRate = CustomOption.Create(10, cs(Janitor.color, "マフィア"), rates, null, true);
			janitorCooldown = CustomOption.Create(11, "死体清掃クールダウン", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

			morphlingSpawnRate = CustomOption.Create(20, cs(Morphling.color, "モーフィング"), rates, null, true);
			morphlingCooldown = CustomOption.Create(21, "変身クールダウン", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
			morphlingDuration = CustomOption.Create(22, "変身継続時間", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

			camouflagerSpawnRate = CustomOption.Create(30, cs(Camouflager.color, "カモフラジャー"), rates, null, true);
			camouflagerCooldown = CustomOption.Create(31, "カモフラジャークールダウン", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
			camouflagerDuration = CustomOption.Create(32, "カモフラージュ継続時間", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

			evilHackerSpawnRate = CustomOption.Create(900, cs(EvilHacker.color, "イビルハッカー"), rates, null, true);
			evilHackerCanCreateMadmate = CustomOption.Create(901, "狂人を作る事が出来るか", false, evilHackerSpawnRate);
			createdMadmateCanDieToSheriff = CustomOption.Create(902, "作成した狂人はシェリフ殺害されるか", false, evilHackerCanCreateMadmate);
			createdMadmateCanEnterVents = CustomOption.Create(903, "作成した狂人は通気孔を使用出来るか", false, evilHackerCanCreateMadmate);
			createdMadmateHasImpostorVision = CustomOption.Create(904, "作成した狂人はインポスターと同じ視界にするか", false, evilHackerCanCreateMadmate);
			createdMadmateNoticeImpostors = CustomOption.Create(905, "作成した狂人が仕事を完了したらインポスターを知る事が出来るか", false, evilHackerCanCreateMadmate);
			createdMadmateExileCrewmate = CustomOption.Create(906, "狂人が追放された時に乗組員を追放するか", false, evilHackerCanCreateMadmate);

			vampireSpawnRate = CustomOption.Create(40, cs(Vampire.color, "吸血鬼"), rates, null, true);
			vampireKillDelay = CustomOption.Create(41, "殺害遅延時間", 10f, 1f, 20f, 1f, vampireSpawnRate);
			vampireCooldown = CustomOption.Create(42, "吸血クールダウン", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
			vampireCanKillNearGarlics = CustomOption.Create(43, "ニンニクの近くで殺害出来るか", true, vampireSpawnRate);

			eraserSpawnRate = CustomOption.Create(230, cs(Eraser.color, "イレーサー"), rates, null, true);
			eraserCooldown = CustomOption.Create(231, "能力消去クールダウン", 30f, 10f, 120f, 5f, eraserSpawnRate);
			eraserCanEraseAnyone = CustomOption.Create(232, "誰でも対象に出来るか", false, eraserSpawnRate);

			tricksterSpawnRate = CustomOption.Create(250, cs(Trickster.color, "トリックスター"), rates, null, true);
			tricksterPlaceBoxCooldown = CustomOption.Create(251, "びっくり箱設置クールダウン", 10f, 0f, 30f, 2.5f, tricksterSpawnRate);
			tricksterLightsOutCooldown = CustomOption.Create(252, "トリックスター停電クールダウン", 30f, 10f, 60f, 5f, tricksterSpawnRate);
			tricksterLightsOutDuration = CustomOption.Create(253, "トリックスター停電継続時間", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

			cleanerSpawnRate = CustomOption.Create(260, cs(Cleaner.color, "清掃員"), rates, null, true);
			cleanerCooldown = CustomOption.Create(261, "死体清掃クールダウン", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

			warlockSpawnRate = CustomOption.Create(270, cs(Warlock.color, "ウォーロック"), rates, null, true);
			warlockCooldown = CustomOption.Create(271, "呪殺クールダウン", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
			warlockRootTime = CustomOption.Create(272, "移動不可能時間", 5f, 0f, 15f, 1f, warlockSpawnRate);

			bountyHunterSpawnRate = CustomOption.Create(320, cs(BountyHunter.color, "バウンティーハンター(賞金稼ぎ)"), rates, null, true);
			bountyHunterBountyDuration = CustomOption.Create(321, "標的切り替わり時間", 60f, 10f, 180f, 10f, bountyHunterSpawnRate);
			bountyHunterReducedCooldown = CustomOption.Create(322, "標的殺害後のキルクール", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
			bountyHunterPunishmentTime = CustomOption.Create(323, "標的以外を殺害後のキルクール", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
			bountyHunterShowArrow = CustomOption.Create(324, "標的を指し示す矢印を表示するか", true, bountyHunterSpawnRate);
			bountyHunterArrowUpdateIntervall = CustomOption.Create(325, "矢印更新時間", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

			witchSpawnRate = CustomOption.Create(370, cs(Witch.color, "魔女"), rates, null, true);
			witchCooldown = CustomOption.Create(371, "呪文詠唱のクールダウン", 30f, 10f, 120f, 5f, witchSpawnRate);
			witchAdditionalCooldown = CustomOption.Create(372, "魔女追加のクールダウン", 10f, 0f, 60f, 5f, witchSpawnRate);
			witchCanSpellAnyone = CustomOption.Create(373, "誰にでも詠唱出来るか", false, witchSpawnRate);
			witchSpellCastingDuration = CustomOption.Create(374, "呪文詠唱にかかる時間", 1f, 0f, 10f, 1f, witchSpawnRate);
			witchTriggerBothCooldowns = CustomOption.Create(375, "両方のクールダウンをトリガーするか", true, witchSpawnRate);
			witchVoteSavesTargets = CustomOption.Create(376, "魔女に投票すると全てのターゲットが保存されるか", true, witchSpawnRate);

			miniSpawnRate = CustomOption.Create(180, cs(Mini.color, "ミニ(子供)"), rates, null, true);
			miniGrowingUpDuration = CustomOption.Create(181, "成長速度", 400f, 100f, 1500f, 100f, miniSpawnRate);

			loversSpawnRate = CustomOption.Create(50, cs(Lovers.color, "恋人"), rates, null, true);
			loversImpLoverRate = CustomOption.Create(51, "恋人の片割れがインポスターになる確率", rates, loversSpawnRate);
			loversBothDie = CustomOption.Create(52, "二人同時に死亡するか", true, loversSpawnRate);
			loversCanHaveAnotherRole = CustomOption.Create(53, "恋人が別の役職を持つか", true, loversSpawnRate);

			guesserSpawnRate = CustomOption.Create(310, cs(Guesser.color, "ゲッサー(推測者)"), rates, null, true);
			guesserIsImpGuesserRate = CustomOption.Create(311, "インポスターになる確率", rates, guesserSpawnRate);
			guesserNumberOfShots = CustomOption.Create(312, "推測回数", 2f, 1f, 15f, 1f, guesserSpawnRate);
			guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, "1会議で複数推測出来るか", false, guesserSpawnRate);
			guesserShowInfoInGhostChat = CustomOption.Create(314, "幽霊チャットを見えるようにするか", true, guesserSpawnRate);
			guesserKillsThroughShield = CustomOption.Create(315, "メディックのシールドを無効化出来るか", true, guesserSpawnRate);

			jesterSpawnRate = CustomOption.Create(60, cs(Jester.color, "てるてる"), rates, null, true);
			jesterCanCallEmergency = CustomOption.Create(61, "緊急会議の招集を出来るか", true, jesterSpawnRate);
			//jesterCanSabotage = CustomOption.Create(62, "妨害をを発生させられるか", true, jesterSpawnRate);

			arsonistSpawnRate = CustomOption.Create(290, cs(Arsonist.color, "放火魔"), rates, null, true);
			arsonistCooldown = CustomOption.Create(291, "油塗りクールダウン", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
			arsonistDuration = CustomOption.Create(292, "油塗るのにかかる時間", 3f, 1f, 10f, 1f, arsonistSpawnRate);

			jackalSpawnRate = CustomOption.Create(220, cs(Jackal.color, "ジャッカル"), rates, null, true);
			jackalKillCooldown = CustomOption.Create(221, "ジャッカル陣営のキルクール時間", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
			jackalCreateSidekickCooldown = CustomOption.Create(222, "サイドキック指名クールダウン", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
			jackalCanUseVents = CustomOption.Create(223, "通気孔を使用出来るか", true, jackalSpawnRate);
			jackalCanCreateSidekick = CustomOption.Create(224, "サイドキックを指名出来るか", false, jackalSpawnRate);
			sidekickPromotesToJackal = CustomOption.Create(225, "ジャッカル死亡後サイドキックが昇格するか", false, jackalSpawnRate);
			sidekickCanKill = CustomOption.Create(226, "サイドキックが殺害出来るか", false, jackalSpawnRate);
			sidekickCanUseVents = CustomOption.Create(227, "サイドキックが通気孔を使用出来るか", true, jackalSpawnRate);
			jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, "昇格したジャッカルが新たにサイドキックを指名出来るか", true, jackalSpawnRate);
			jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, "インポスターをサイドキックに出来るか", true, jackalSpawnRate);
			jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, "インポスターと同じ視界にするか", false, jackalSpawnRate);
			//jackalCanSeeEngineerVent = CustomOption.Create(431, "ジャッカルはエンジニアが通気孔にいるかを判別出来るか", false, jackalSpawnRate);

			vultureSpawnRate = CustomOption.Create(340, cs(Vulture.color, "ハゲタカ"), rates, null, true);
			vultureCooldown = CustomOption.Create(341, "捕食クールダウン", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
			vultureNumberToWin = CustomOption.Create(342, "勝利までに捕食する死体の数", 4f, 0f, 5f, 1f, vultureSpawnRate);
			vultureCanUseVents = CustomOption.Create(343, "通気孔を使用出来るか", true, vultureSpawnRate);
			vultureShowArrows = CustomOption.Create(344, "死体を指す矢印を表示するか", true, vultureSpawnRate);

			lawyerSpawnRate = CustomOption.Create(350, cs(Lawyer.color, "弁護士"), rates, null, true);
			lawyerTargetKnows = CustomOption.Create(351, "依頼主を知る事が出来るか", true, lawyerSpawnRate);
			lawyerWinsAfterMeetings = CustomOption.Create(352, "会議の後に勝利するか", false, lawyerSpawnRate);
			lawyerNeededMeetings = CustomOption.Create(353, "勝利の為に必要な会議数", 5f, 1f, 15f, 1f, lawyerWinsAfterMeetings);
			lawyerVision = CustomOption.Create(354, "視界", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
			lawyerKnowsRole = CustomOption.Create(355, "依頼主の役職を知る事が出来るか", false, lawyerSpawnRate);
			pursuerCooldown = CustomOption.Create(356, "インポスター無力化クールダウン", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
			pursuerBlanksNumber = CustomOption.Create(357, "インポスター無力化の回数", 5f, 0f, 20f, 1f, lawyerSpawnRate);

			shifterSpawnRate = CustomOption.Create(70, cs(Shifter.color, "シフター"), rates, null, true);
			shifterShiftsModifiers = CustomOption.Create(71, "対象のステータスもシフトするか", false, shifterSpawnRate);

			mayorSpawnRate = CustomOption.Create(80, cs(Mayor.color, "市長"), rates, null, true);

			engineerSpawnRate = CustomOption.Create(90, cs(Engineer.color, "エンジニア"), rates, null, true);
			engineerNumberOfFixes = CustomOption.Create(91, "サボタージュ修理可能数", 1f, 0f, 3f, 1f, engineerSpawnRate);
			engineerHighlightForImpostors = CustomOption.Create(92, "インポスターに通気孔使用を視認されるか", true, engineerSpawnRate);
			engineerHighlightForTeamJackal = CustomOption.Create(93, "ジャッカル陣営に通気孔使用を視認されるか", true, engineerSpawnRate);

			sheriffSpawnRate = CustomOption.Create(100, cs(Sheriff.color, "シェリフ(保安官)"), rates, null, true);
			sheriffCooldown = CustomOption.Create(101, "シェリフクールダウン", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
			sheriffCanKillNeutrals = CustomOption.Create(102, "その他陣営も殺害出来るか", false, sheriffSpawnRate);
			sheriffNumberOfShots = CustomOption.Create(103, "襲撃可能回数", 1f, 1f, 15, 1f, sheriffSpawnRate);

			lighterSpawnRate = CustomOption.Create(110, cs(Lighter.color, "ライター"), rates, null, true);
			lighterModeLightsOnVision = CustomOption.Create(111, "通常時ライト点灯中視界", 2f, 0.25f, 5f, 0.25f, lighterSpawnRate);
			lighterModeLightsOffVision = CustomOption.Create(112, "停電時ライト点灯中視界", 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate);
			lighterCooldown = CustomOption.Create(113, "ライトクールダウン", 30f, 5f, 120f, 5f, lighterSpawnRate);
			lighterDuration = CustomOption.Create(114, "ライト継続時間", 5f, 2.5f, 60f, 2.5f, lighterSpawnRate);

			detectiveSpawnRate = CustomOption.Create(120, cs(Detective.color, "探偵"), rates, null, true);
			detectiveAnonymousFootprints = CustomOption.Create(121, "無色の足跡にするか", false, detectiveSpawnRate);
			detectiveFootprintIntervall = CustomOption.Create(122, "足跡の間隔", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
			detectiveFootprintDuration = CustomOption.Create(123, "足跡が残る時間", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
			detectiveReportNameDuration = CustomOption.Create(124, "死体発見時に犯人の名前が分かる時間", 0, 0, 60, 2.5f, detectiveSpawnRate);
			detectiveReportColorDuration = CustomOption.Create(125, "死体発見時に犯人の色が分かる時間", 20, 0, 120, 2.5f, detectiveSpawnRate);

			timeMasterSpawnRate = CustomOption.Create(130, cs(TimeMaster.color, "タイムマスター"), rates, null, true);
			timeMasterCooldown = CustomOption.Create(131, "タイムシールドクールダウン", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
			timeMasterRewindTime = CustomOption.Create(132, "巻き戻し時間", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
			timeMasterShieldDuration = CustomOption.Create(133, "タイムシールド継続時間", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

			medicSpawnRate = CustomOption.Create(140, cs(Medic.color, "メディック"), rates, null, true);
			medicShowShielded = CustomOption.Create(143, "盾持ちプレイヤーの表示", new string[] { "全員", "対象者&メディック", "メディック" }, medicSpawnRate);
			medicShowAttemptToShielded = CustomOption.Create(144, "盾持ちプレイヤーが攻撃された事を知る事が出来るか", false, medicSpawnRate);
			medicSetShieldAfterMeeting = CustomOption.Create(145, "付与後の会議後にシールドが有効になるか", false, medicSpawnRate);
			medicShowAttemptToMedic = CustomOption.Create(146, "メディックが盾持ちプレイヤーの攻撃を知る事が出来るか", false, medicSpawnRate);

			swapperSpawnRate = CustomOption.Create(150, cs(Swapper.color, "スワッパー"), rates, null, true);
			swapperCanCallEmergency = CustomOption.Create(151, "緊急会議の招集を出来るか", false, swapperSpawnRate);
			swapperCanOnlySwapOthers = CustomOption.Create(152, "自身を入替の対象にするか", false, swapperSpawnRate);

			seerSpawnRate = CustomOption.Create(160, cs(Seer.color, "予言者"), rates, null, true);
			seerMode = CustomOption.Create(161, "モード", new string[] { "死の点滅&幽霊が見える", "死の点滅が見える", "幽霊が見える" }, seerSpawnRate);
			seerLimitSoulDuration = CustomOption.Create(163, "時間経過で幽霊が消えるか", false, seerSpawnRate);
			seerSoulDuration = CustomOption.Create(162, "幽霊の見える時間", 15f, 0f, 60f, 5f, seerLimitSoulDuration);

			hackerSpawnRate = CustomOption.Create(170, cs(Hacker.color, "ハッカー"), rates, null, true);
			hackerCooldown = CustomOption.Create(171, "ハッキングクールダウン", 30f, 0f, 60f, 5f, hackerSpawnRate);
			hackerHackeringDuration = CustomOption.Create(172, "ハッキング時間", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
			hackerOnlyColorType = CustomOption.Create(173, "色の種類のみが見えるか", false, hackerSpawnRate);

			trackerSpawnRate = CustomOption.Create(200, cs(Tracker.color, "トラッカー"), rates, null, true);
			trackerUpdateIntervall = CustomOption.Create(201, "追跡更新間隔", 5f, 2.5f, 30f, 2.5f, trackerSpawnRate);
			trackerResetTargetAfterMeeting = CustomOption.Create(202, "会議後に追跡対象者をリセットするか", false, trackerSpawnRate);
			trackerCanTrackCorpses = CustomOption.Create(203, "死体を追跡出来るか", true, trackerSpawnRate);
			trackerCorpsesTrackingCooldown = CustomOption.Create(204, "死体追跡クールダウン", 30f, 0f, 120f, 5f, trackerCanTrackCorpses);
			trackerCorpsesTrackingDuration = CustomOption.Create(205, "死体追跡期間", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);

			snitchSpawnRate = CustomOption.Create(210, cs(Snitch.color, "スニッチ"), rates, null, true);
			snitchLeftTasksForReveal = CustomOption.Create(211, "スニッチが公開されるタスク残量", 1f, 0f, 5f, 1f, snitchSpawnRate);
			snitchIncludeTeamJackal = CustomOption.Create(212, "ジャッカル陣営にも含めるか", false, snitchSpawnRate);
			snitchTeamJackalUseDifferentArrowColor = CustomOption.Create(213, "ジャッカル陣営に異なる矢印の色を使用するか", true, snitchIncludeTeamJackal);

			spySpawnRate = CustomOption.Create(240, cs(Spy.color, "スパイ"), rates, null, true);
			spyCanDieToSheriff = CustomOption.Create(241, "スパイがシェリフに殺害されるか", false, spySpawnRate);
			spyImpostorsCanKillAnyone = CustomOption.Create(242, "スパイがインポスターに殺害されるか", true, spySpawnRate);
			spyCanEnterVents = CustomOption.Create(243, "通気孔を使用出来るか", false, spySpawnRate);
			spyHasImpostorVision = CustomOption.Create(244, "インポスターと同じ視界にするか", false, spySpawnRate);

			securityGuardSpawnRate = CustomOption.Create(280, cs(SecurityGuard.color, "警備員"), rates, null, true);
			securityGuardCooldown = CustomOption.Create(281, "警備員クールダウン", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
			securityGuardTotalScrews = CustomOption.Create(282, "ネジ所持数", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
			securityGuardCamPrice = CustomOption.Create(283, "カメラ設置に必要なネジの数", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
			securityGuardVentPrice = CustomOption.Create(284, "通気孔を塞ぐのに必要なネジの数", 1f, 1f, 15f, 1f, securityGuardSpawnRate);

			baitSpawnRate = CustomOption.Create(330, cs(Bait.color, "ベイト(餌)"), rates, null, true);
			baitHighlightAllVents = CustomOption.Create(331, "通気孔使用時にベントを発光させるか", false, baitSpawnRate);
			baitReportDelay = CustomOption.Create(332, "餌自身の殺害後の報告までの時間", 0f, 0f, 10f, 1f, baitSpawnRate);
			baitShowKillFlash = CustomOption.Create(333, "殺人鬼にフラッシュで警告するか", true, baitSpawnRate);

			mediumSpawnRate = CustomOption.Create(360, cs(Medium.color, "霊媒師"), rates, null, true);
			mediumCooldown = CustomOption.Create(361, "質問クールダウン", 30f, 5f, 120f, 5f, mediumSpawnRate);
			mediumDuration = CustomOption.Create(362, "質問時間", 3f, 0f, 15f, 1f, mediumSpawnRate);
			mediumOneTimeUse = CustomOption.Create(363, "幽霊は一度だけ質問を受ける事が出来るか", false, mediumSpawnRate);

			madmateSpawnRate = CustomOption.Create(910, cs(Madmate.color, "狂人"), rates, null, true);
			madmateCanDieToSheriff = CustomOption.Create(911, "狂人がシェリフに殺害されるか", false, madmateSpawnRate);
			madmateCanEnterVents = CustomOption.Create(912, "通気孔を使用出来るか", false, madmateSpawnRate);
			madmateHasImpostorVision = CustomOption.Create(913, "インポスターと同じ視界にするか", false, madmateSpawnRate);
			madmateNoticeImpostors = CustomOption.Create(914, "狂人が仕事を完了したらインポスターを知る事が出来るか", false, madmateSpawnRate);
			madmateCommonTasks = CustomOption.Create(915, "共通仕事数", 0f, 0f, 4f, 1f, madmateNoticeImpostors);
			madmateShortTasks = CustomOption.Create(916, "短い仕事数", 0f, 0f, 23f, 1f, madmateNoticeImpostors);
			madmateLongTasks = CustomOption.Create(917, "長い仕事数", 0f, 0f, 15f, 1f, madmateNoticeImpostors);
			madmateExileCrewmate = CustomOption.Create(918, "狂人が追放された時に乗組員を追放するか", false, madmateSpawnRate);

			// Other options
			maxNumberOfMeetings = CustomOption.Create(3, "合計緊急会議回数(市長対象外)", 10, 0, 15, 1, null, true);
			blockSkippingInEmergencyMeetings = CustomOption.Create(4, "投票スキップ禁止にするか", false);
			noVoteIsSelfVote = CustomOption.Create(5, "自投票を禁止にするか", false, blockSkippingInEmergencyMeetings);
			hidePlayerNames = CustomOption.Create(6, "名前を表示しないか", false);
			allowParallelMedBayScans = CustomOption.Create(7, "医務室スキャンタスクの同時進行を許可するか", false);
			dynamicMap = CustomOption.Create(8, "ランダムマップで遊ぶか", false, null, false);

			blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
			blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
			blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
			blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
			
		}
	}
}
