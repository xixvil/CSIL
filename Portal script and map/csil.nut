START <- 0

function Think()
{
	if (START == 0)
	{
		SendToConsole("log off") // resetting log settings
		SendToConsole("sv_cheats 1") // for next command :)
		SendToConsole("sv_script_think_interval 0.033") // 0.033 = Think() function calling interval
		SendToConsole("con_logfile csil.log") // csil.log - logfile for CSIL
		SendToConsole("log on") // enable logging
		START = 1
		return
	}
	local player_ent;
	player_ent = Entities.FindByClassname(player_ent, "player") // getting player entity
	if (player_ent != null) // if OK, then...
	{
		local vel = player_ent.GetVelocity() // getting her veolcity vector
		local amp = abs(100 * vel.z / 1024) // calculating signal amplitude by vertical velocity
		local amplitude = amp <= 100 ? amp : 100 // if amp was great then 100 then making this equal 100
		printl("***to_interface "+amplitude) // writing to log file = sending to interface
	}
}
