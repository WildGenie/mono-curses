using System;
using Mono.Curses;

class Demo {
	static void Main ()
	{
		// Standard Init sequence
		Curses.initscr ();
		Curses.cbreak ();
		Curses.noecho ();

		// Recommended
		Curses.nonl ();

		Window.Standard.intrflush (false);
		Window.Standard.keypad (true);

		// Shutdown
		Curses.endwin ();
	}
}
