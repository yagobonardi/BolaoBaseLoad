using var client = new HttpClient();

var drivers = await client.GetStringAsync("http://ergast.com/api/f1/2023/drivers");
var scheduleRacesForSeason = await client.GetStringAsync("http://ergast.com/api/f1/2023");
var qualifyingResults = await client.GetStringAsync("http://ergast.com/api/f1/2023/1/qualifying");
var raceResult = await client.GetStringAsync("http://ergast.com/api/f1/2023/1/results"); //with fatest lap