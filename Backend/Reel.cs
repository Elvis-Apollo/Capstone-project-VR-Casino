using System;
public class Reel{
	private int value;
	
	public Reel(){
		Random rnd = new Random();
		value = rnd.Next(1,7); //initial value 
		// input randomizer for initial value;
	}
	public void spin(){
		Random rnd = new Random();
		value = rnd.Next(1,7); //randomizes btw 1-6
	}
	public void spin (int new_value){
		if (new_value > 0 && new_value <6){
			value = new_value;
		//setter value;
		}
		else(){ Console.WriteLine("Value invalid! Try again");}
	}
	public int getValue(){
		return value();
	}
	
	public static void Main(string[] args){
		Reel r1 = new Reel();
		Reel r2 = new Reel();
		Reel r3 = new Reel();
		
		Console.WriteLine(r1.getValue());
		Console.WriteLine(r2.getValue());
		Console.WriteLine(r3.getValue());
		
		r1.spin();
		r2.spin(6);
		r3.spin(10);
		
		Console.WriteLine(r1.getValue());
		Console.WriteLine(r2.getValue());
		Console.WriteLine(r3.getValue());
	}
}