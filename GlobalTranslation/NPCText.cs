using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using UsefulNPCs.NPCs;

namespace UNPCCP.GlobalTranslation
{
	public class NPCText : GlobalNPC
	{
		public override void GetChat(NPC npc, ref string chat)
		{
			int Clothier = NPC.FindFirstNPC(NPCID.Clothier);
			int Merena = NPC.FindFirstNPC(ModContent.NPCType<Alchemist>());
			if (npc.type == ModContent.NPCType<Alchemist>())
				if (Clothier >= 0 && chat == "I could've saved more people with my potions..." + Main.npc[Clothier].GivenName + "Salute to the dead, but not forgotten.")

                {
					chat = "有趣的是，服装商" + Main.npc[Clothier].GivenName + "过去经常来我们这里购买的一些奇异的布料.";
				}
				switch (chat)
				{
					case "I wonder what my sister Sylia is up to nowadays, do you know her?":
					chat = "我想知道我妹妹赛莉亚现在在干什么，你认识她吗？";
					break;
					case "I'm gonna be the very best, like no one ever was...":
					chat = "我要成为万人之上的至尊...";
					break;
					case "原始的文本":
					chat = "你想替换成什么文本";
					break;
				}
			}
        }

		// 此处为需要点选项之后出现的对话
		// 看原模组代码时，搜索 “Main.npcChatText = ” 可查找到大部分
		public override void OnChatButtonClicked(NPC npc, bool firstButton)
		{
			// 先判断 NPC 是不是我们要改的
			if (npc.type == ModContent.NPCType<Merena>())
			{
				// 还是 Replace 替换，前面填原文，后面填译文
				Main.npcChatText = Main.npcChatText.Replace("What are you standing there for, go kill Verlia! She's an enemy of the royal capital and she has a book I need lmao", "你站在那里干什么，去杀了薇莉娅！她是阿尔卡迪亚的敌人，而且她身上还有一本我需要的书");
                Main.npcChatText = Main.npcChatText.Replace("Hey, I have nothing else for you to do! Thanks for all of your help, have you checked out my shop yet?", "嘿，我没有别的事要你做了！谢谢你的帮助，你看过我的商店了吗？");// 这是所有任务完成后的对话
                Main.npcChatText = Main.npcChatText.Replace("1", "啊");
				Main.npcChatText = Main.npcChatText.Replace("2", "吧");
				Main.npcChatText = Main.npcChatText.Replace("3", "从");
				Main.npcChatText = Main.npcChatText.Replace("4", "的");
				Main.npcChatText = Main.npcChatText.Replace("5", "额");
				Main.npcChatText = Main.npcChatText.Replace("6", "发");
				
				// 如果对话中出现了玩家的名字，则使用 Main.LocalPlayer.name
				// Main.npcChatText = Main.npcChatText.Replace("There we go, " + Main.LocalPlayer.name + ", good as new. It won't last long, but maybe you'll notice some more spring in your step. Make sure to stay safe out there, hero!", "好了, " + Main.LocalPlayer.name + ", 你的鞋子焕然如新. 虽然不能保持太久, 但也许你能感觉到你的脚步更加轻快自如了. 在外一定要注意安全, 英雄!");
			}
		}
    }
}