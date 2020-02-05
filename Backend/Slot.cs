using System;
class Slot{
	public Reel[] reels;
	public Slot(){
		reels = new Reel[4];
	}
	public void spin();
	public void payOut();
	
	public class Win:Slot{
		public void spin(){
			reels[0].spin();
			Console.WriteLine(reels[0].getValue);
			for (int i =1; i<4; i++){
				reels[i].spin(reels[0].getValue());
				Console.WriteLine(reels[i].getValue);
			}
		}
		public void payOut(){
			Console.WriteLine("You won $100");
		}
		
	}
	public class Lose:Slot{
		public void spin(){
			reels[0].spin();
			Console.WriteLine(reels[0].getValue);
			for(int i =1; i<3; i++){
				reels[i].spin(reels[0].getValue());
				Console.WriteLine(reels[i].getValue);
			}
			reels[3].spin();
			Console.WriteLine(reels[3].getValue);
		}
		public void payOut(){
			Console.WriteLine("You Lose $10");
		}
	}
	
	public class NearMisses:Slot{
		public void spin(){
			reels[0].spin();
			Console.WriteLine(reels[0].getValue);
			for(int i =1; i<3; i++){
				reels[i].spin(reels[0].getValue());
				Console.WriteLine(reels[i].getValue);
			}
			if(reels[0].getValue<6){
				reels[3].spin((reels[0].getValue)+1);
			}
			else(){
				reels[3].spin((reels[0].getValue)-5);
			}
		}
		public void payOut(){
			Console.WriteLine("You Lose $10");
		}
	}
	
	public static void Main(string[] args){
		Win s1 = new Win();
		Lose s2 = new Lose();
		NearMisses s3 = new NearMisses();
		
		s1.spin();
		s1.payOut();
		s2.spin();
		s2.payOut();
		s3.spin();
		s3.payOut();
		
	}
	
}