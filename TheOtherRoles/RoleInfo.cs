using HarmonyLib;
using System.Linq;
using System;
using System.Collections.Generic;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;

namespace TheOtherRoles
{
    class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;

        RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
        }

        public static RoleInfo jester = new RoleInfo("�Ă�Ă�", Jester.color, "���[�ŒǕ������", "���[�ŒǕ������", RoleId.Jester);
        public static RoleInfo mayor = new RoleInfo("�s��", Mayor.color, "���Ȃ��̓��[��2�[�ɂȂ�܂�", "���Ȃ��̓��[��2�[�ɂȂ�܂�", RoleId.Mayor);
        public static RoleInfo engineer = new RoleInfo("�G���W�j�A", Engineer.color, "�D�̏d�v�ȃV�X�e�����ێ��o���܂�", "�D���C���o���܂�", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("�V�F���t", Sheriff.color, "<color=#FF1919FF>�C���|�X�^�[</color>���E�Q�o���܂�", "�l�O���E�Q�o���܂�", RoleId.Sheriff);
        public static RoleInfo lighter = new RoleInfo("���C�^�[", Lighter.color, "���Ȃ��̌��͌����ď����܂���", "���Ȃ��̌��͌����ď����܂���", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("�g��", Godfather.color, "��g�����E�Q����", "��g�����E�Q����", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("�g��", Mafioso.color, "<color=#FF1919FF>�}�t�B�A</color>�Ƌ��͂��ď�g�����E�Q����", "��g�����E�Q����", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("�W�F�j�^�[", Janitor.color, "���̂��B�����Ƃ�<color=#FF1919FF>�}�t�B�A</color>�Ƌ��͂���", "���̂��B��", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("���[�t�B���O", Morphling.color, "������Ȃ��悤�Ɏp��ς��܂��傤", "�����ڂ�ς��Ęf�킹", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("�J���t���W���[", Camouflager.color, "��g�����J���t���[�W�����ĎE��", "�����B��", RoleId.Camouflager);
        public static RoleInfo evilHacker = new RoleInfo("�C�r���n�b�J�[", EvilHacker.color, "�V�X�e�����n�b�N���ď�g�����E��", "�V�X�e�����n�b�N���ď�g�����E��", RoleId.EvilHacker);
        public static RoleInfo vampire = new RoleInfo("�z���S", Vampire.color, "���ݏ��ŏ�g�����E��", "��g��������", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("�C���[�T�[", Eraser.color, "��g�����E���A�ނ�̖���������", "��g���̖���������", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("�g���b�N�X�^�[", Trickster.color, "�т����蔠���g���đ��̐l����������", "�G����������", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("���|��", Cleaner.color, "��g�����E���A���Ղ��c����", "���̂�Еt����", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("�E�H�[���b�N", Warlock.color, "��g�����􂢎E��", "��g�����􂢎E��", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("�o�E���e�B�[�n���^�[", BountyHunter.color, "�W�I��_���Ď��̂𑝂₹", "�W�I��_���Ď��̂𑝂₹", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("�T��", Detective.color, "���Ղ𒲂ׂ�<color=#FF1919FF>�C���|�X�^�[</color>��������", "���Ղ𒲂ׂ�", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("�^�C���}�X�^�[", TimeMaster.color, "�^�C���V�[���h�ŏ�g�������", "�^�C���V�[���h�ŏ�g�������", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("���f�B�b�N", Medic.color, "�����g�p���ď�g�������", "�����g�p���ď�g�������", RoleId.Medic);
        public static RoleInfo shifter = new RoleInfo("�V�t�^�[", Shifter.color, "���������ւ���<color=#FF1919FF>�C���|�X�^�[</color>��f�킹", "���������ւ��ăC���|�X�^�[��f�킹", RoleId.Shifter);
        public static RoleInfo swapper = new RoleInfo("�X���b�p�[", Swapper.color, "���[�����ւ���<color=#FF1919FF>�C���|�X�^�[</color>��Ǖ�����", "���[�����ւ��ăC���|�X�^�[��f�킹", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("�\����", Seer.color, "�v���C���[�̎��S���m�F�o����", "�v���C���[�̎��S���m�F�o����", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("�n�b�J�[", Hacker.color, "�V�X�e���Ƀn�b�L���O����<color=#FF1919FF>�C���|�X�^�[</color>��������", "�C���|�X�^�[��������ׂɃn�b�L���O����", RoleId.Hacker);
        public static RoleInfo niceMini = new RoleInfo("�i�C�X�~�j", Mini.color, "��������܂ŒN�����Ȃ��������܂���", "��������܂Œ݂����", RoleId.Mini);
        public static RoleInfo evilMini = new RoleInfo("�C�r���~�j", Palette.ImpostorRed, "��������܂ŒN�����Ȃ��������܂���", "������E�Q���Ď��̂𑝂₹", RoleId.Mini);
        public static RoleInfo tracker = new RoleInfo("�g���b�J�[", Tracker.color, "<color=#FF1919FF>�C���|�X�^�[</color>��ǐՂ���", "�C���|�X�^�[��ǐՂ���", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("�X�j�b�`", Snitch.color, "�^�X�N���������āA<color=#FF1919FF>�C���|�X�^�[</color>��T��", "�^�X�N�����������ăC���|�X�^�[��T��", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("�W���b�J��", Jackal.color, "���ׂɃN���[���C�g��<color=#FF1919FF>�C���|�X�^�[</color>���E�Q����", "�F���E�Q����", RoleId.Jackal);
        public static RoleInfo sidekick = new RoleInfo("�T�C�h�L�b�N", Sidekick.color, "�W���b�J�����F���E�Q����̂���`��", "�W���b�J�����F���E�Q����̂���`��", RoleId.Sidekick);
        public static RoleInfo spy = new RoleInfo("�X�p�C", Spy.color, "���Ԃ̐U�������<color=#FF1919FF>�C���|�X�^�[</color>������������", "�C���|�X�^�[������������", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("�x����", SecurityGuard.color, "�J�����̐ݒu�ƃx���g���ǂ�", "�J�����̐ݒu�ƃx���g���ǂ�", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("���Ζ�", Arsonist.color, "���̃v���C���[��R�₹", "���̃v���C���[��R�₹", RoleId.Arsonist);
        public static RoleInfo goodGuesser = new RoleInfo("�i�C�X�Q�b�T�[", Guesser.color, "�������Č���", "�������Č���", RoleId.Guesser);
        public static RoleInfo badGuesser = new RoleInfo("�C�r���Q�b�T�[", Palette.ImpostorRed, "�������Č���", "�������Č���", RoleId.Guesser);
        public static RoleInfo bait = new RoleInfo("�x�C�g", Bait.color, "�a���T����<color=#FF1919FF>�C���|�X�^�[</color>���t��o��", "�a���T���ăC���|�X�^�[���t��o��", RoleId.Bait);
        public static RoleInfo vulture = new RoleInfo("�n�Q�^�J", Vulture.color, "���ׂɎ��̂�H�ׂ�", "���ׂɎ��̂�H�ׂ�", RoleId.Vulture);
        public static RoleInfo medium = new RoleInfo("��}�t", Medium.color, "���𓾂�ׂɗH��Ɏ��₵��", "���𓾂�ׂɗH��Ɏ��₵��", RoleId.Medium);
        public static RoleInfo madmate = new RoleInfo("���l", Madmate.color, "<color=#FF1919FF>�C���|�X�^�[</color>����`��", "�C���|�X�^�[����`��", RoleId.Madmate);
        public static RoleInfo impostor = new RoleInfo("�C���|�X�^�[", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "��g���̎d����W�Q���ĎE�Q����"), "��g���̎d����W�Q���ĎE�Q����", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("��g��", Color.white, "<color=#FF1919FF>�C���|�X�^�[</color>��������", "�d��������������", RoleId.Crewmate);
        public static RoleInfo lover = new RoleInfo("���l", Lovers.color, $"���l�Ɛ����c��", $"���l�Ɛ����c��", RoleId.Lover);

        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            evilHacker,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            bountyHunter,
            niceMini,
            evilMini,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            vulture,
            crewmate,
            shifter,
            mayor,
            engineer,
            sheriff,
            lighter,
            detective,
            timeMaster,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            madmate
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff) infos.Add(sheriff);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == EvilHacker.evilHacker) infos.Add(evilHacker);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Shifter.shifter) infos.Add(shifter);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Mini.mini) infos.Add(p.Data.Role.IsImpostor ? evilMini : niceMini);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.guesser) infos.Add(p.Data.Role.IsImpostor ? badGuesser : goodGuesser);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Bait.bait) infos.Add(bait);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Madmate.madmate) infos.Add(madmate);

            // Default roles
            if (infos.Count == 0 && p.Data.Role.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.Role.IsImpostor) infos.Add(crewmate); // Just Crewmate

            // Modifier
            if (p == Lovers.lover1|| p == Lovers.lover2) infos.Add(lover);

            return infos;
        }

        public static String GetRole(PlayerControl p) {
            string roleName;
            roleName = String.Join("", getRoleInfoForPlayer(p).Select(x => x.name).ToArray());
            if (roleName.Contains("Lover")) roleName.Replace("Lover", "");
            return roleName;
        }
    }
}
