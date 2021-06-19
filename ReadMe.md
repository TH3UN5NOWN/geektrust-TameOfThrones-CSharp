# Tame of Thrones - C#

## Building and Execution
**Please paste the input file in the folder InputFiles in the directory _bin\Debug\netcoreapp3.1\InputFiles_**
```
	dotnet build -o bin
	dotnet bin/geektrust.dll InputFiles/<filename>.txt
```

## Logic Breakdown
* The Main() reads the input from the files and adds each line into a list of strings
* This list is sent as an argument to the CheckForRuler() method that calls the splits each line into 2 substrings 
	* Kingdom name
	* Message to kingdom
* It then calls the IsAlly() method on the kingdom name and the message to tell whether the kingdom is an ally or not
	if the kingdom is an ally, it will add it to a list of all allies
* If the number of allies is 3 or more, the output will contain SPACE as ruler with all the names of allies. Else, it prints None.

---
### Sanjeev Ravi