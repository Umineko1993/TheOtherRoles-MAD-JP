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
		public static string[] presets = new string[]{ "�v���Z�b�g 1", "�v���Z�b�g 2", "�v���Z�b�g 3", "�v���Z�b�g 4", "�v���Z�b�g 5" };

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
			presetSelection = CustomOption.Create(0, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "�v���Z�b�g"), presets, null, true);
			activateRoles = CustomOption.Create(7, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Mod�̖�E��L���ɂ��A�o�j���̖�E�𖳌��ɂ���"), true, null, true);

			// Using new id's for the options to not break compatibilty with older versions
			crewmateRolesCountMin = CustomOption.Create(300, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��g����E �ŏ�"), 0f, 0f, 15f, 1f, null, true);
			crewmateRolesCountMax = CustomOption.Create(301, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��g����E �ő�"), 0f, 0f, 15f, 1f);
			neutralRolesCountMin = CustomOption.Create(302, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���̑��w�c��E �ŏ�"), 0f, 0f, 15f, 1f);
			neutralRolesCountMax = CustomOption.Create(303, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���̑��w�c��E �ő�"), 0f, 0f, 15f, 1f);
			impostorRolesCountMin = CustomOption.Create(304, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "�C���|�X�^�[��E �ŏ�"), 0f, 0f, 3f, 1f);
			impostorRolesCountMax = CustomOption.Create(305, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "�C���|�X�^�[��E �ő�"), 0f, 0f, 3f, 1f);

			adminTimer = CustomOption.Create(99, "�A�h�~���̗��p�\����", 10f, 0f, 120f, 1f);
			enabledAdminTimer = CustomOption.Create(98, "�A�h�~���̎��Ԑ�����L���ɂ���", true);
			hideTaskOverlayOnSabMap = CustomOption.Create(97, "�W�Q�}�b�v�ŋU�̎d�����\���ɂ��邩", false);

			mafiaSpawnRate = CustomOption.Create(10, cs(Janitor.color, "�}�t�B�A"), rates, null, true);
			janitorCooldown = CustomOption.Create(11, "���̐��|�N�[���_�E��", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

			morphlingSpawnRate = CustomOption.Create(20, cs(Morphling.color, "���[�t�B���O"), rates, null, true);
			morphlingCooldown = CustomOption.Create(21, "�ϐg�N�[���_�E��", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
			morphlingDuration = CustomOption.Create(22, "�ϐg�p������", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

			camouflagerSpawnRate = CustomOption.Create(30, cs(Camouflager.color, "�J���t���W���["), rates, null, true);
			camouflagerCooldown = CustomOption.Create(31, "�J���t���W���[�N�[���_�E��", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
			camouflagerDuration = CustomOption.Create(32, "�J���t���[�W���p������", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

			evilHackerSpawnRate = CustomOption.Create(900, cs(EvilHacker.color, "�C�r���n�b�J�["), rates, null, true);
			evilHackerCanCreateMadmate = CustomOption.Create(901, "���l����鎖���o���邩", false, evilHackerSpawnRate);
			createdMadmateCanDieToSheriff = CustomOption.Create(902, "�쐬�������l�̓V�F���t�E�Q����邩", false, evilHackerCanCreateMadmate);
			createdMadmateCanEnterVents = CustomOption.Create(903, "�쐬�������l�͒ʋC�E���g�p�o���邩", false, evilHackerCanCreateMadmate);
			createdMadmateHasImpostorVision = CustomOption.Create(904, "�쐬�������l�̓C���|�X�^�[�Ɠ������E�ɂ��邩", false, evilHackerCanCreateMadmate);
			createdMadmateNoticeImpostors = CustomOption.Create(905, "�쐬�������l���d��������������C���|�X�^�[��m�鎖���o���邩", false, evilHackerCanCreateMadmate);
			createdMadmateExileCrewmate = CustomOption.Create(906, "���l���Ǖ����ꂽ���ɏ�g����Ǖ����邩", false, evilHackerCanCreateMadmate);

			vampireSpawnRate = CustomOption.Create(40, cs(Vampire.color, "�z���S"), rates, null, true);
			vampireKillDelay = CustomOption.Create(41, "�E�Q�x������", 10f, 1f, 20f, 1f, vampireSpawnRate);
			vampireCooldown = CustomOption.Create(42, "�z���N�[���_�E��", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
			vampireCanKillNearGarlics = CustomOption.Create(43, "�j���j�N�̋߂��ŎE�Q�o���邩", true, vampireSpawnRate);

			eraserSpawnRate = CustomOption.Create(230, cs(Eraser.color, "�C���[�T�["), rates, null, true);
			eraserCooldown = CustomOption.Create(231, "�\�͏����N�[���_�E��", 30f, 10f, 120f, 5f, eraserSpawnRate);
			eraserCanEraseAnyone = CustomOption.Create(232, "�N�ł��Ώۂɏo���邩", false, eraserSpawnRate);

			tricksterSpawnRate = CustomOption.Create(250, cs(Trickster.color, "�g���b�N�X�^�["), rates, null, true);
			tricksterPlaceBoxCooldown = CustomOption.Create(251, "�т����蔠�ݒu�N�[���_�E��", 10f, 0f, 30f, 2.5f, tricksterSpawnRate);
			tricksterLightsOutCooldown = CustomOption.Create(252, "�g���b�N�X�^�[��d�N�[���_�E��", 30f, 10f, 60f, 5f, tricksterSpawnRate);
			tricksterLightsOutDuration = CustomOption.Create(253, "�g���b�N�X�^�[��d�p������", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

			cleanerSpawnRate = CustomOption.Create(260, cs(Cleaner.color, "���|��"), rates, null, true);
			cleanerCooldown = CustomOption.Create(261, "���̐��|�N�[���_�E��", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

			warlockSpawnRate = CustomOption.Create(270, cs(Warlock.color, "�E�H�[���b�N"), rates, null, true);
			warlockCooldown = CustomOption.Create(271, "��E�N�[���_�E��", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
			warlockRootTime = CustomOption.Create(272, "�ړ��s�\����", 5f, 0f, 15f, 1f, warlockSpawnRate);

			bountyHunterSpawnRate = CustomOption.Create(320, cs(BountyHunter.color, "�o�E���e�B�[�n���^�[(�܋��҂�)"), rates, null, true);
			bountyHunterBountyDuration = CustomOption.Create(321, "�W�I�؂�ւ�莞��", 60f, 10f, 180f, 10f, bountyHunterSpawnRate);
			bountyHunterReducedCooldown = CustomOption.Create(322, "�W�I�E�Q��̃L���N�[��", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
			bountyHunterPunishmentTime = CustomOption.Create(323, "�W�I�ȊO���E�Q��̃L���N�[��", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
			bountyHunterShowArrow = CustomOption.Create(324, "�W�I���w����������\�����邩", true, bountyHunterSpawnRate);
			bountyHunterArrowUpdateIntervall = CustomOption.Create(325, "���X�V����", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

			witchSpawnRate = CustomOption.Create(370, cs(Witch.color, "����"), rates, null, true);
			witchCooldown = CustomOption.Create(371, "�����r���̃N�[���_�E��", 30f, 10f, 120f, 5f, witchSpawnRate);
			witchAdditionalCooldown = CustomOption.Create(372, "�����ǉ��̃N�[���_�E��", 10f, 0f, 60f, 5f, witchSpawnRate);
			witchCanSpellAnyone = CustomOption.Create(373, "�N�ɂł��r���o���邩", false, witchSpawnRate);
			witchSpellCastingDuration = CustomOption.Create(374, "�����r���ɂ����鎞��", 1f, 0f, 10f, 1f, witchSpawnRate);
			witchTriggerBothCooldowns = CustomOption.Create(375, "�����̃N�[���_�E�����g���K�[���邩", true, witchSpawnRate);
			witchVoteSavesTargets = CustomOption.Create(376, "�����ɓ��[����ƑS�Ẵ^�[�Q�b�g���ۑ�����邩", true, witchSpawnRate);

			miniSpawnRate = CustomOption.Create(180, cs(Mini.color, "�~�j(�q��)"), rates, null, true);
			miniGrowingUpDuration = CustomOption.Create(181, "�������x", 400f, 100f, 1500f, 100f, miniSpawnRate);

			loversSpawnRate = CustomOption.Create(50, cs(Lovers.color, "���l"), rates, null, true);
			loversImpLoverRate = CustomOption.Create(51, "���l�̕Њ��ꂪ�C���|�X�^�[�ɂȂ�m��", rates, loversSpawnRate);
			loversBothDie = CustomOption.Create(52, "��l�����Ɏ��S���邩", true, loversSpawnRate);
			loversCanHaveAnotherRole = CustomOption.Create(53, "���l���ʂ̖�E������", true, loversSpawnRate);

			guesserSpawnRate = CustomOption.Create(310, cs(Guesser.color, "�Q�b�T�[(������)"), rates, null, true);
			guesserIsImpGuesserRate = CustomOption.Create(311, "�C���|�X�^�[�ɂȂ�m��", rates, guesserSpawnRate);
			guesserNumberOfShots = CustomOption.Create(312, "������", 2f, 1f, 15f, 1f, guesserSpawnRate);
			guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, "1��c�ŕ��������o���邩", false, guesserSpawnRate);
			guesserShowInfoInGhostChat = CustomOption.Create(314, "�H��`���b�g��������悤�ɂ��邩", true, guesserSpawnRate);
			guesserKillsThroughShield = CustomOption.Create(315, "���f�B�b�N�̃V�[���h�𖳌����o���邩", true, guesserSpawnRate);

			jesterSpawnRate = CustomOption.Create(60, cs(Jester.color, "�Ă�Ă�"), rates, null, true);
			jesterCanCallEmergency = CustomOption.Create(61, "�ً}��c�̏��W���o���邩", true, jesterSpawnRate);
			//jesterCanSabotage = CustomOption.Create(62, "�W�Q���𔭐��������邩", true, jesterSpawnRate);

			arsonistSpawnRate = CustomOption.Create(290, cs(Arsonist.color, "���Ζ�"), rates, null, true);
			arsonistCooldown = CustomOption.Create(291, "���h��N�[���_�E��", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
			arsonistDuration = CustomOption.Create(292, "���h��̂ɂ����鎞��", 3f, 1f, 10f, 1f, arsonistSpawnRate);

			jackalSpawnRate = CustomOption.Create(220, cs(Jackal.color, "�W���b�J��"), rates, null, true);
			jackalKillCooldown = CustomOption.Create(221, "�W���b�J���w�c�̃L���N�[������", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
			jackalCreateSidekickCooldown = CustomOption.Create(222, "�T�C�h�L�b�N�w���N�[���_�E��", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
			jackalCanUseVents = CustomOption.Create(223, "�ʋC�E���g�p�o���邩", true, jackalSpawnRate);
			jackalCanCreateSidekick = CustomOption.Create(224, "�T�C�h�L�b�N���w���o���邩", false, jackalSpawnRate);
			sidekickPromotesToJackal = CustomOption.Create(225, "�W���b�J�����S��T�C�h�L�b�N�����i���邩", false, jackalSpawnRate);
			sidekickCanKill = CustomOption.Create(226, "�T�C�h�L�b�N���E�Q�o���邩", false, jackalSpawnRate);
			sidekickCanUseVents = CustomOption.Create(227, "�T�C�h�L�b�N���ʋC�E���g�p�o���邩", true, jackalSpawnRate);
			jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, "���i�����W���b�J�����V���ɃT�C�h�L�b�N���w���o���邩", true, jackalSpawnRate);
			jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, "�C���|�X�^�[���T�C�h�L�b�N�ɏo���邩", true, jackalSpawnRate);
			jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, "�C���|�X�^�[�Ɠ������E�ɂ��邩", false, jackalSpawnRate);
			//jackalCanSeeEngineerVent = CustomOption.Create(431, "�W���b�J���̓G���W�j�A���ʋC�E�ɂ��邩�𔻕ʏo���邩", false, jackalSpawnRate);

			vultureSpawnRate = CustomOption.Create(340, cs(Vulture.color, "�n�Q�^�J"), rates, null, true);
			vultureCooldown = CustomOption.Create(341, "�ߐH�N�[���_�E��", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
			vultureNumberToWin = CustomOption.Create(342, "�����܂łɕߐH���鎀�̂̐�", 4f, 0f, 5f, 1f, vultureSpawnRate);
			vultureCanUseVents = CustomOption.Create(343, "�ʋC�E���g�p�o���邩", true, vultureSpawnRate);
			vultureShowArrows = CustomOption.Create(344, "���̂��w������\�����邩", true, vultureSpawnRate);

			lawyerSpawnRate = CustomOption.Create(350, cs(Lawyer.color, "�ٌ�m"), rates, null, true);
			lawyerTargetKnows = CustomOption.Create(351, "�˗����m�鎖���o���邩", true, lawyerSpawnRate);
			lawyerWinsAfterMeetings = CustomOption.Create(352, "��c�̌�ɏ������邩", false, lawyerSpawnRate);
			lawyerNeededMeetings = CustomOption.Create(353, "�����ׂ̈ɕK�v�ȉ�c��", 5f, 1f, 15f, 1f, lawyerWinsAfterMeetings);
			lawyerVision = CustomOption.Create(354, "���E", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
			lawyerKnowsRole = CustomOption.Create(355, "�˗���̖�E��m�鎖���o���邩", false, lawyerSpawnRate);
			pursuerCooldown = CustomOption.Create(356, "�C���|�X�^�[���͉��N�[���_�E��", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
			pursuerBlanksNumber = CustomOption.Create(357, "�C���|�X�^�[���͉��̉�", 5f, 0f, 20f, 1f, lawyerSpawnRate);

			shifterSpawnRate = CustomOption.Create(70, cs(Shifter.color, "�V�t�^�["), rates, null, true);
			shifterShiftsModifiers = CustomOption.Create(71, "�Ώۂ̃X�e�[�^�X���V�t�g���邩", false, shifterSpawnRate);

			mayorSpawnRate = CustomOption.Create(80, cs(Mayor.color, "�s��"), rates, null, true);

			engineerSpawnRate = CustomOption.Create(90, cs(Engineer.color, "�G���W�j�A"), rates, null, true);
			engineerNumberOfFixes = CustomOption.Create(91, "�T�{�^�[�W���C���\��", 1f, 0f, 3f, 1f, engineerSpawnRate);
			engineerHighlightForImpostors = CustomOption.Create(92, "�C���|�X�^�[�ɒʋC�E�g�p�����F����邩", true, engineerSpawnRate);
			engineerHighlightForTeamJackal = CustomOption.Create(93, "�W���b�J���w�c�ɒʋC�E�g�p�����F����邩", true, engineerSpawnRate);

			sheriffSpawnRate = CustomOption.Create(100, cs(Sheriff.color, "�V�F���t(�ۈ���)"), rates, null, true);
			sheriffCooldown = CustomOption.Create(101, "�V�F���t�N�[���_�E��", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
			sheriffCanKillNeutrals = CustomOption.Create(102, "���̑��w�c���E�Q�o���邩", false, sheriffSpawnRate);
			sheriffNumberOfShots = CustomOption.Create(103, "�P���\��", 1f, 1f, 15, 1f, sheriffSpawnRate);

			lighterSpawnRate = CustomOption.Create(110, cs(Lighter.color, "���C�^�["), rates, null, true);
			lighterModeLightsOnVision = CustomOption.Create(111, "�ʏ펞���C�g�_�������E", 2f, 0.25f, 5f, 0.25f, lighterSpawnRate);
			lighterModeLightsOffVision = CustomOption.Create(112, "��d�����C�g�_�������E", 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate);
			lighterCooldown = CustomOption.Create(113, "���C�g�N�[���_�E��", 30f, 5f, 120f, 5f, lighterSpawnRate);
			lighterDuration = CustomOption.Create(114, "���C�g�p������", 5f, 2.5f, 60f, 2.5f, lighterSpawnRate);

			detectiveSpawnRate = CustomOption.Create(120, cs(Detective.color, "�T��"), rates, null, true);
			detectiveAnonymousFootprints = CustomOption.Create(121, "���F�̑��Ղɂ��邩", false, detectiveSpawnRate);
			detectiveFootprintIntervall = CustomOption.Create(122, "���Ղ̊Ԋu", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
			detectiveFootprintDuration = CustomOption.Create(123, "���Ղ��c�鎞��", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
			detectiveReportNameDuration = CustomOption.Create(124, "���̔������ɔƐl�̖��O�������鎞��", 0, 0, 60, 2.5f, detectiveSpawnRate);
			detectiveReportColorDuration = CustomOption.Create(125, "���̔������ɔƐl�̐F�������鎞��", 20, 0, 120, 2.5f, detectiveSpawnRate);

			timeMasterSpawnRate = CustomOption.Create(130, cs(TimeMaster.color, "�^�C���}�X�^�["), rates, null, true);
			timeMasterCooldown = CustomOption.Create(131, "�^�C���V�[���h�N�[���_�E��", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
			timeMasterRewindTime = CustomOption.Create(132, "�����߂�����", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
			timeMasterShieldDuration = CustomOption.Create(133, "�^�C���V�[���h�p������", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

			medicSpawnRate = CustomOption.Create(140, cs(Medic.color, "���f�B�b�N"), rates, null, true);
			medicShowShielded = CustomOption.Create(143, "�������v���C���[�̕\��", new string[] { "�S��", "�Ώێ�&���f�B�b�N", "���f�B�b�N" }, medicSpawnRate);
			medicShowAttemptToShielded = CustomOption.Create(144, "�������v���C���[���U�����ꂽ����m�鎖���o���邩", false, medicSpawnRate);
			medicSetShieldAfterMeeting = CustomOption.Create(145, "�t�^��̉�c��ɃV�[���h���L���ɂȂ邩", false, medicSpawnRate);
			medicShowAttemptToMedic = CustomOption.Create(146, "���f�B�b�N���������v���C���[�̍U����m�鎖���o���邩", false, medicSpawnRate);

			swapperSpawnRate = CustomOption.Create(150, cs(Swapper.color, "�X���b�p�["), rates, null, true);
			swapperCanCallEmergency = CustomOption.Create(151, "�ً}��c�̏��W���o���邩", false, swapperSpawnRate);
			swapperCanOnlySwapOthers = CustomOption.Create(152, "���g����ւ̑Ώۂɂ��邩", false, swapperSpawnRate);

			seerSpawnRate = CustomOption.Create(160, cs(Seer.color, "�\����"), rates, null, true);
			seerMode = CustomOption.Create(161, "���[�h", new string[] { "���̓_��&�H�삪������", "���̓_�ł�������", "�H�삪������" }, seerSpawnRate);
			seerLimitSoulDuration = CustomOption.Create(163, "���Ԍo�߂ŗH�삪�����邩", false, seerSpawnRate);
			seerSoulDuration = CustomOption.Create(162, "�H��̌����鎞��", 15f, 0f, 60f, 5f, seerLimitSoulDuration);

			hackerSpawnRate = CustomOption.Create(170, cs(Hacker.color, "�n�b�J�["), rates, null, true);
			hackerCooldown = CustomOption.Create(171, "�n�b�L���O�N�[���_�E��", 30f, 0f, 60f, 5f, hackerSpawnRate);
			hackerHackeringDuration = CustomOption.Create(172, "�n�b�L���O����", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
			hackerOnlyColorType = CustomOption.Create(173, "�F�̎�ނ݂̂������邩", false, hackerSpawnRate);

			trackerSpawnRate = CustomOption.Create(200, cs(Tracker.color, "�g���b�J�["), rates, null, true);
			trackerUpdateIntervall = CustomOption.Create(201, "�ǐՍX�V�Ԋu", 5f, 2.5f, 30f, 2.5f, trackerSpawnRate);
			trackerResetTargetAfterMeeting = CustomOption.Create(202, "��c��ɒǐՑΏێ҂����Z�b�g���邩", false, trackerSpawnRate);
			trackerCanTrackCorpses = CustomOption.Create(203, "���̂�ǐՏo���邩", true, trackerSpawnRate);
			trackerCorpsesTrackingCooldown = CustomOption.Create(204, "���̒ǐՃN�[���_�E��", 30f, 0f, 120f, 5f, trackerCanTrackCorpses);
			trackerCorpsesTrackingDuration = CustomOption.Create(205, "���̒ǐՊ���", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);

			snitchSpawnRate = CustomOption.Create(210, cs(Snitch.color, "�X�j�b�`"), rates, null, true);
			snitchLeftTasksForReveal = CustomOption.Create(211, "�X�j�b�`�����J�����^�X�N�c��", 1f, 0f, 5f, 1f, snitchSpawnRate);
			snitchIncludeTeamJackal = CustomOption.Create(212, "�W���b�J���w�c�ɂ��܂߂邩", false, snitchSpawnRate);
			snitchTeamJackalUseDifferentArrowColor = CustomOption.Create(213, "�W���b�J���w�c�ɈقȂ���̐F���g�p���邩", true, snitchIncludeTeamJackal);

			spySpawnRate = CustomOption.Create(240, cs(Spy.color, "�X�p�C"), rates, null, true);
			spyCanDieToSheriff = CustomOption.Create(241, "�X�p�C���V�F���t�ɎE�Q����邩", false, spySpawnRate);
			spyImpostorsCanKillAnyone = CustomOption.Create(242, "�X�p�C���C���|�X�^�[�ɎE�Q����邩", true, spySpawnRate);
			spyCanEnterVents = CustomOption.Create(243, "�ʋC�E���g�p�o���邩", false, spySpawnRate);
			spyHasImpostorVision = CustomOption.Create(244, "�C���|�X�^�[�Ɠ������E�ɂ��邩", false, spySpawnRate);

			securityGuardSpawnRate = CustomOption.Create(280, cs(SecurityGuard.color, "�x����"), rates, null, true);
			securityGuardCooldown = CustomOption.Create(281, "�x�����N�[���_�E��", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
			securityGuardTotalScrews = CustomOption.Create(282, "�l�W������", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
			securityGuardCamPrice = CustomOption.Create(283, "�J�����ݒu�ɕK�v�ȃl�W�̐�", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
			securityGuardVentPrice = CustomOption.Create(284, "�ʋC�E���ǂ��̂ɕK�v�ȃl�W�̐�", 1f, 1f, 15f, 1f, securityGuardSpawnRate);

			baitSpawnRate = CustomOption.Create(330, cs(Bait.color, "�x�C�g(�a)"), rates, null, true);
			baitHighlightAllVents = CustomOption.Create(331, "�ʋC�E�g�p���Ƀx���g�𔭌������邩", false, baitSpawnRate);
			baitReportDelay = CustomOption.Create(332, "�a���g�̎E�Q��̕񍐂܂ł̎���", 0f, 0f, 10f, 1f, baitSpawnRate);
			baitShowKillFlash = CustomOption.Create(333, "�E�l�S�Ƀt���b�V���Ōx�����邩", true, baitSpawnRate);

			mediumSpawnRate = CustomOption.Create(360, cs(Medium.color, "��}�t"), rates, null, true);
			mediumCooldown = CustomOption.Create(361, "����N�[���_�E��", 30f, 5f, 120f, 5f, mediumSpawnRate);
			mediumDuration = CustomOption.Create(362, "���⎞��", 3f, 0f, 15f, 1f, mediumSpawnRate);
			mediumOneTimeUse = CustomOption.Create(363, "�H��͈�x����������󂯂鎖���o���邩", false, mediumSpawnRate);

			madmateSpawnRate = CustomOption.Create(910, cs(Madmate.color, "���l"), rates, null, true);
			madmateCanDieToSheriff = CustomOption.Create(911, "���l���V�F���t�ɎE�Q����邩", false, madmateSpawnRate);
			madmateCanEnterVents = CustomOption.Create(912, "�ʋC�E���g�p�o���邩", false, madmateSpawnRate);
			madmateHasImpostorVision = CustomOption.Create(913, "�C���|�X�^�[�Ɠ������E�ɂ��邩", false, madmateSpawnRate);
			madmateNoticeImpostors = CustomOption.Create(914, "���l���d��������������C���|�X�^�[��m�鎖���o���邩", false, madmateSpawnRate);
			madmateCommonTasks = CustomOption.Create(915, "���ʎd����", 0f, 0f, 4f, 1f, madmateNoticeImpostors);
			madmateShortTasks = CustomOption.Create(916, "�Z���d����", 0f, 0f, 23f, 1f, madmateNoticeImpostors);
			madmateLongTasks = CustomOption.Create(917, "�����d����", 0f, 0f, 15f, 1f, madmateNoticeImpostors);
			madmateExileCrewmate = CustomOption.Create(918, "���l���Ǖ����ꂽ���ɏ�g����Ǖ����邩", false, madmateSpawnRate);

			// Other options
			maxNumberOfMeetings = CustomOption.Create(3, "���v�ً}��c��(�s���ΏۊO)", 10, 0, 15, 1, null, true);
			blockSkippingInEmergencyMeetings = CustomOption.Create(4, "���[�X�L�b�v�֎~�ɂ��邩", false);
			noVoteIsSelfVote = CustomOption.Create(5, "�����[���֎~�ɂ��邩", false, blockSkippingInEmergencyMeetings);
			hidePlayerNames = CustomOption.Create(6, "���O��\�����Ȃ���", false);
			allowParallelMedBayScans = CustomOption.Create(7, "�㖱���X�L�����^�X�N�̓����i�s�������邩", false);
			dynamicMap = CustomOption.Create(8, "�����_���}�b�v�ŗV�Ԃ�", false, null, false);

			blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
			blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
			blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
			blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
			
		}
	}
}
