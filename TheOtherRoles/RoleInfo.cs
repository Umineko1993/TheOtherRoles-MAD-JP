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

        public static RoleInfo jester = new RoleInfo("てるてる", Jester.color, "投票で追放されろ", "投票で追放されろ", RoleId.Jester);
        public static RoleInfo mayor = new RoleInfo("市長", Mayor.color, "あなたの投票は2票になります", "あなたの投票は2票になります", RoleId.Mayor);
        public static RoleInfo engineer = new RoleInfo("エンジニア", Engineer.color, "船の重要なシステムを維持出来ます", "船を修理出来ます", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("シェリフ", Sheriff.color, "<color=#FF1919FF>インポスター</color>を殺害出来ます", "人外を殺害出来ます", RoleId.Sheriff);
        public static RoleInfo lighter = new RoleInfo("ライター", Lighter.color, "あなたの光は決して消えません", "あなたの光は決して消えません", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("組長", Godfather.color, "乗組員を殺害せよ", "乗組員を殺害せよ", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("組員", Mafioso.color, "<color=#FF1919FF>マフィア</color>と協力して乗組員を殺害せよ", "乗組員を殺害せよ", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("ジェニター", Janitor.color, "死体を隠すことで<color=#FF1919FF>マフィア</color>と協力する", "死体を隠せ", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("モーフィング", Morphling.color, "見つからないように姿を変えましょう", "見た目を変えて惑わせ", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("カモフラジャー", Camouflager.color, "乗組員をカモフラージュして殺せ", "他を隠せ", RoleId.Camouflager);
        public static RoleInfo evilHacker = new RoleInfo("イビルハッカー", EvilHacker.color, "システムをハックして乗組員を殺せ", "狂人を作成して乗組員を惑わせろ", RoleId.EvilHacker);
        public static RoleInfo vampire = new RoleInfo("吸血鬼", Vampire.color, "かみ傷で乗組員を殺せ", "乗組員を噛め", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("イレーサー", Eraser.color, "乗組員を殺し、彼らの役割を消せ", "乗組員の役割を消せ", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("トリックスター", Trickster.color, "びっくり箱を使って他の人を驚かせろ", "敵を驚かせろ", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("清掃員", Cleaner.color, "乗組員を殺し、痕跡を残すな", "死体を片付けろ", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("ウォーロック", Warlock.color, "乗組員を呪い殺せ", "乗組員を呪い殺せ", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("バウンティーハンター", BountyHunter.color, "標的を狙って死体を増やせ", "標的を狙って死体を増やせ", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("探偵", Detective.color, "足跡を調べて<color=#FF1919FF>インポスター</color>を見つけろ", "足跡を調べろ", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("タイムマスター", TimeMaster.color, "タイムシールドで乗組員を守れ", "タイムシールドで乗組員を守れ", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("メディック", Medic.color, "盾を使用して乗組員を守れ", "盾を使用して乗組員を守れ", RoleId.Medic);
        public static RoleInfo shifter = new RoleInfo("シフター", Shifter.color, "役割を入れ替えて<color=#FF1919FF>インポスター</color>を惑わせ", "役割を入れ替えてインポスターを惑わせ", RoleId.Shifter);
        public static RoleInfo swapper = new RoleInfo("スワッパー", Swapper.color, "投票を入れ替えて<color=#FF1919FF>インポスター</color>を追放しろ", "投票を入れ替えてインポスターを惑わせ", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("予言者", Seer.color, "プレイヤーの死亡を確認出来る", "プレイヤーの死亡を確認出来る", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("ハッカー", Hacker.color, "システムにハッキングして<color=#FF1919FF>インポスター</color>を見つけろ", "インポスターを見つける為にハッキングしろ", RoleId.Hacker);
        public static RoleInfo niceMini = new RoleInfo("ナイスミニ", Mini.color, "成長するまで誰もあなたを傷つけません", "成長するまで吊られるな", RoleId.Mini);
        public static RoleInfo evilMini = new RoleInfo("イビルミニ", Palette.ImpostorRed, "成長するまで誰もあなたを傷つけません", "成長後殺害して死体を増やせ", RoleId.Mini);
        public static RoleInfo tracker = new RoleInfo("トラッカー", Tracker.color, "<color=#FF1919FF>インポスター</color>を追跡しろ", "インポスターを追跡しろ", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("スニッチ", Snitch.color, "タスクを完了して、<color=#FF1919FF>インポスター</color>を探せ", "タスクを完了させてインポスターを探せ", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("ジャッカル", Jackal.color, "勝つ為にクルーメイトと<color=#FF1919FF>インポスター</color>を殺害せよ", "皆を殺害せよ", RoleId.Jackal);
        public static RoleInfo sidekick = new RoleInfo("サイドキック", Sidekick.color, "ジャッカルが皆を殺害するのを手伝え", "ジャッカルが皆を殺害するのを手伝え", RoleId.Sidekick);
        public static RoleInfo spy = new RoleInfo("スパイ", Spy.color, "仲間の振りをして<color=#FF1919FF>インポスター</color>を混乱させよ", "インポスターを混乱させよ", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("警備員", SecurityGuard.color, "カメラの設置とベントを塞げ", "カメラの設置とベントを塞げ", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("放火魔", Arsonist.color, "他のプレイヤーを燃やせ", "他のプレイヤーを燃やせ", RoleId.Arsonist);
        public static RoleInfo goodGuesser = new RoleInfo("ナイスゲッサー", Guesser.color, "推理して撃て", "推理して撃て", RoleId.Guesser);
        public static RoleInfo badGuesser = new RoleInfo("イビルゲッサー", Palette.ImpostorRed, "推理して撃て", "推理して撃て", RoleId.Guesser);
        public static RoleInfo bait = new RoleInfo("ベイト", Bait.color, "餌を撒いて<color=#FF1919FF>インポスター</color>を炙り出せ", "餌を撒いてインポスターを炙り出せ", RoleId.Bait);
        public static RoleInfo vulture = new RoleInfo("ハゲタカ", Vulture.color, "勝つ為に死体を食べろ", "勝つ為に死体を食べろ", RoleId.Vulture);
        public static RoleInfo medium = new RoleInfo("霊媒師", Medium.color, "情報を得る為に幽霊に質問しろ", "情報を得る為に幽霊に質問しろ", RoleId.Medium);
        public static RoleInfo madmate = new RoleInfo("狂人", Madmate.color, "<color=#FF1919FF>インポスター</color>を手伝え", "インポスターを手伝え", RoleId.Madmate);
        public static RoleInfo lawyer = new RoleInfo("弁護士", Lawyer.color, "依頼主を守れ", "依頼主を守れ", RoleId.Lawyer, true);
        public static RoleInfo pursuer = new RoleInfo("追跡者", Pursuer.color, "<color=#FF1919FF>インポスター</color>を無力化させろ", "インポスターを無力化させろ", RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo("インポスター", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "乗組員の仕事を妨害して殺害しろ"), "乗組員の仕事を妨害して殺害しろ", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("乗組員", Color.white, "<color=#FF1919FF>インポスター</color>を見つけろ", "仕事を完了させよ", RoleId.Crewmate);
        public static RoleInfo lover = new RoleInfo("恋人", Lovers.color, $"恋人と生き残れ", $"恋人と生き残れ", RoleId.Lover);
        public static RoleInfo witch = new RoleInfo("魔女", Witch.color, "敵に呪文をかけろ", "敵に呪文をかけろ", RoleId.Witch);

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
            witch,
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
            pursuer,
            lawyer,
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
            if (p == Witch.witch) infos.Add(witch);
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
            if (p == Lawyer.lawyer) infos.Add(lawyer);
            if (p == Pursuer.pursuer) infos.Add(pursuer);

            // Default roles
            if (infos.Count == 0 && p.Data.Role.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.Role.IsImpostor) infos.Add(crewmate); // Just Crewmate

            // Modifier
            if (p == Lovers.lover1|| p == Lovers.lover2) infos.Add(lover);

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && PlayerControl.LocalPlayer != Lawyer.target) roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            return roleName;
        }
    }
}
