Her går jeg i gang med å lage et program som skal gå gjennom desember (12) måned og finne ut hvilken dag som er Tirsdag
når det går gjennom dag for dag. Det skal da finne ut med kodene (if) eller (else) om det er Tirsdag
er det ikke tirsdag får jeg svar it's not Tuesday og er det tirsdag som datoen 23.12.2025 får jeg beskjeden good Tuesday.

						
	start program				using System
								
	setter inn år				int year =2025
	sette inn måneden			int month = 12
				
	fra dag 1 til 31 kjør			int day = 1; day <= 31; day++)
					
	opprett dato				DateTime date = New Datetime(year, month, day)
	
	skriv ut dato på måten                  Console.Writeline("d.M.yyyy"))
	
	Hvis dato er av ukedagen tirsdag        if (date.DayofWeek == DayofWeek.Tuesday

	god tirsdag 				Console.Writeline("good Tuesday")
	
	viss ikke 				else
	
	Det er ikke Tirsdag			Console.Writeline("it's not Tuesday");
	
	bruk for åpenrom mellom linjene		Console.Writeline()

	
			