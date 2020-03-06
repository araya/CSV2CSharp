//
// ComboSkill
//
public class ComboSkillInfo { 

	//5001
	public int Id { get; set; }

	//移形换影
	public string Name { get; set; }

	//"蓄力时，召唤1个幻影向前攻击，造成{0}伤害
	public string Desc { get; set; }

	//蓄力结束后，瞬移到幻影所在位置"
	public string IconId { get; set; }

	//BookIcon2
	public string UnlockID { get; set; }

	//1003
	public int NeedItem { get; set; }

	//3026;3018;3030
	public string SkillID { get; set; }

}
