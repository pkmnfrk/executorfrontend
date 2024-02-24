Executor Frontend
=================

This is a tool meant to assist bruteforcing efforts on the Portal 2 TAS discord. However,
technically it is more generic than that.

Given a command and a working directory, it will run the command a specified number of times, and
make a best effort to keep that number running at all times. You may optionally specify a period
with a different number (eg, for overnight efforts).

Any time the current number of running instances does not match the desired number it will spin up a
new instance or kill an old instance as appropriate. This is performed at most once per minute so as
to not cause extra load on the computer.

If the thing you are running happens to be Portal 2, you may also turn on a "stuck instance" check.
This will enable logging in the Source instance, and monitor the log for TAS-related output. If it
doesn't see any for two minutes, it will assume the instance is dead and kill it. It will then be
respawned by the usual mechanisms.

I'm open to adding new features if anyone is interested!

Known issues
------------

* The Show Window checkbox does not work due to how the Source engine shows its console.
* New windows will always be spawned in the foreground on the current desktop. Fixing this is non
  trivial, but I would like to try.
* The stuck instance prevention can't tell if it is the server that breaks, rather than a single
  instance. Manual intervention might be required in this case.
  
