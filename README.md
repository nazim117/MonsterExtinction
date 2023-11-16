# MonsterExtinction
There will be given two sequences of integers. 
The first sequence represents the armor of the monsters. Each integer value represents the armor of a different monster.
The second sequence represents the soldier's striking impact. Each integer value represents the strength of a strike performed by the soldier.
Battle Rules:
•	The monster at the front will be the first to face the soldier. Take the first armor value and the last strike strength value and compare the values.
•	If the soldier's striking impact is greater than or equal to the monster's armor, the monster is killed, and its armor is removed from the sequence. The soldier's strike impact is then decreased by the value of the monster's armor. The remaining striking impact value is added to the next strike element in the sequence (if any) or is considered to be the last and only element. Zero values should not be pushed back to the sequence.
•	If the soldier's striking impact is less than the monster's armor, the strike is performed, but the monster survives with reduced armor. The soldier's striking impact value is removed from the sequence, and the monster's armor value is decreased by the original strike value. The monster is then moved to the back of the sequence. 
•	The battle goes on until one of the sequences becomes empty.
