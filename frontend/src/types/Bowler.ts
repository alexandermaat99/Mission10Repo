export type Bowler = {
  bowlerId: number;
  bowlerLastName: string;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
  team: { teamId: number; teamName: string };
};

// namespace bowlingAPI.Data;

// public partial class Bowler
// {
//     [Key]
//     public int BowlerId { get; set; }

//     public string? BowlerLastName { get; set; }

//     public string? BowlerFirstName { get; set; }

//     public string? BowlerMiddleInit { get; set; }

//     public string? BowlerAddress { get; set; }

//     public string? BowlerCity { get; set; }

//     public string? BowlerState { get; set; }

//     public string? BowlerZip { get; set; }

//     public string? BowlerPhoneNumber { get; set; }

//     [ForeignKey("TeamId")]
//     public int? TeamId { get; set; }

//     public virtual ICollection<BowlerScore> BowlerScores { get; set; } = new List<BowlerScore>();

//     public virtual Team? Team { get; set; }
