//
// Mission
//
public class MissionInfo { 

	//10101
	public int Id { get; set; }

	//任务1-1
	public string Name { get; set; }

	//任务1-1描述
	public string Decs { get; set; }

	//1
	public int MissionType { get; set; }

	//0
	public int Fmission { get; set; }

	//3;5;14400
	public string MissionTime { get; set; }

	//1001
	public int OpenChapter { get; set; }

	//5:1;1:1000
	public string Reward { get; set; }

	//2040:5;2041:5;2042;3
	public string ExReward { get; set; }

	//0
	public int Chance { get; set; }

	//1
	public int AdPower { get; set; }

}
