# MonsterExtinction
There will be given two sequences of integers. 
The first sequence represents the armor of the monsters. Each integer value represents the armor of a different monster.
The second sequence represents the soldier's striking impact. Each integer value represents the strength of a strike performed by the soldier.
Battle Rules:
•	The monster at the front will be the first to face the soldier. Take the first armor value and the last strike strength value and compare the values.
•	If the soldier's striking impact is greater than or equal to the monster's armor, the monster is killed, and its armor is removed from the sequence. The soldier's strike impact is then decreased by the value of the monster's armor. The remaining striking impact value is added to the next strike element in the sequence (if any) or is considered to be the last and only element. Zero values should not be pushed back to the sequence.
•	If the soldier's striking impact is less than the monster's armor, the strike is performed, but the monster survives with reduced armor. The soldier's striking impact value is removed from the sequence, and the monster's armor value is decreased by the original strike value. The monster is then moved to the back of the sequence. 
•	The battle goes on until one of the sequences becomes empty.

# Delivery Boy

You are a pizza delivery boy with a motorized vehicle that delivers pizza in a neighborhood. The neighborhood is represented by a matrix - field. Each cell in the field represents a part of the neighborhood, and it can contain one of the following elements:
•	'B' - Represents the starting position of the delivery boy.
•	'A' - Represents an address where a pizza needs to be delivered.
•	'*' - Represents an obstacle or an area where the delivery boy cannot drive.
•	'P' - Represents the pizza restaurant.
•	'-' - Represents the road, the delivery boy can drive over it.
In the beginning, you will be given N and M – integers, separated by a single space - " ", indicating the field’s dimensions. On the next N lines, you will receive strings, representing the rows of the area, with M columns. You must keep data for the initial position of the delivery boy as you will need it later for the final output.
The delivery boy must carefully navigate through the streets, following the commands that will be received on each of the following lines- "up", "down", "right", and "left", moving one position at a time. Each step he takes, the '-'(dash) cells he passes (road) through become '.' (dot) to indicate his path. However, the roads may cross, and the boy can ride over the same road again and again. That means the boy can drive over '.'-cell also.
In this pizza delivery adventure, the delivery boy starts his journey from the position marked as 'B' on the neighborhood field. His first task is to make his way to the pizza restaurant marked as 'P' and collect the delicious pizza. Once he collects the pizza, the position 'P' is marked as 'R' and a message is displayed on the Console: "Pizza is collected. 10 minutes for delivery."
However, the neighborhood is not without obstacles. Whenever the delivery boy encounters a cell marked with '*', it signifies an obstacle, and he cannot make a move in that direction. He must remain in his current position and find an alternative route. The delivery boy should wait for the next command.
If, at any point during his journey, the delivery boy steps out of the neighborhood field (matrix boundaries), it means he has ventured beyond the streets of the neighborhood. In such a case, the delivery boy will be considered late for the delivery, and unfortunately, the delivery will be canceled. The following message should be displayed on the Console: "The delivery is late. Order is canceled."
The delivery boy will always collect the pizza ('P'), before heading to the address, marked as 'A', ensuring a successful delivery.
Once the delivery boy successfully reaches an address marked as 'A', he joyfully delivers the pizza, completing his mission. The position 'A' is marked as 'P'. A message will be displayed on the Console: "Pizza is delivered on time! Next order..."
Remember, the delivery boy must follow the commands, avoid obstacles, and ensure timely pizza deliveries to the addresses. Good luck!
In the end, print the final state of the matrix (neighborhood area) with the delivery boy in its starting position. If the boy has been out of the field, mark his starting position with an empty space. Each row is on a new line.

