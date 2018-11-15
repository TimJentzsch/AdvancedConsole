using System;

// Assembly marked as compliant
[assembly: CLSCompliant(true)]

namespace AdvancedConsole
{
	/// <summary>
	/// <para>Represents the standard input, output, and error streams for console applications.</para>
	/// <para>Non-static wrapper class for <see cref="Console"/>.</para>
	/// </summary>
	/// <remarks>
	/// <para>
	/// The console is an operating system window where users interact with the operating system or with a text-based console application by entering text input through the computer keyboard, and by reading text output from the computer terminal. For example, in the Windows operating system, the console is called the Command Prompt window and accepts MS-DOS commands. The <see cref="BaseConsole"/> class provides basic support for applications that read characters from, and write characters to, the console. 
	/// </para>
	/// <para>
	/// <see cref="BaseConsole"/> is a non-static wrapper class for <see cref="Console"/>, to allow extension methods and inheritance. Visit <see href="https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.7.2">the MSDN documentation</see> for details.
	/// </para>
	/// </remarks>
	[CLSCompliant(true)]
	public class BaseConsole
	{
		#region Wrapper Fields

		/// <summary>
		/// Gets or sets the background color of the console.
		/// </summary>
		/// <value>A value that specifies the background color of the console; that is, the color that appears behind each character. The default is <see cref="ConsoleColor.Black"/>.</value>
		/// <exception cref="ArgumentException">The color specified in a set operation is not a valid member of <see cref="ConsoleColor"/>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <remarks>
		/// <para>
		/// A change to the <see cref="BackgroundColor"/> property affects only output that is written to individual character cells after the background color is changed. To change the background color of the console window as a whole, set the <see cref="BackgroundColor"/> property and call the <see cref="Clear"/> method.
		/// </para>
		/// <para>
		/// A get operation for a Windows-based application, in which a console does not exist, returns <see cref="ConsoleColor.Black"/>.
		/// </para>
		/// </remarks>
		/// <seealso cref="Console.BackgroundColor"/>
		public static ConsoleColor BackgroundColor
		{
			get => Console.BackgroundColor;
			set => Console.BackgroundColor = value;
		}

		/// <summary>
		/// Gets or sets the height of the buffer area.
		/// </summary>
		/// <value>The current height, in rows, of the buffer area.</value>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is greater than or equal to <see cref="Int16.MaxValue"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is less than <see cref="WindowTop"/> + <see cref="WindowHeight"/>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <remarks>
		/// <para>
		/// This property defines the number of rows (or lines) stored in the buffer that is accessed by a console mode window. In contrast, the <see cref="WindowHeight"/> property defines the number of rows that are actually displayed in the console window at any particular time. If the number of rows actually written to the buffer exceeds the number of rows defined by the <see cref="WindowHeight"/> property, the window can be scrolled vertically so that it displays a contiguous number of rows that are equal to the <see cref="WindowHeight"/> property and are located anywhere in the buffer. 
		/// </para>
		/// <para>
		/// If a set operation decreases the value of the <see cref="BufferHeight"/> property, the uppermost lines are removed. For example, if the number of lines is reduced from 300 to 250, lines 0 through 49 are removed, and the existing lines 50 through 299 become lines 0 through 249.
		/// </para>
		/// </remarks>
		/// <seealso cref="Console.BufferHeight"/>
		public static int BufferHeight
		{
			get => Console.BufferHeight;
			set => Console.BufferHeight = value;
		}

		/// <summary>
		/// Gets or sets the width of the buffer area.
		/// </summary>
		/// <value>The current width, in columns, of the buffer area.</value>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is greater than or equal to <see cref="Int16.MaxValue"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is less than <see cref="WindowLeft"/> + <see cref="WindowWidth"/>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.BufferWidth"/>
		public static int BufferWidth
		{
			get => Console.BufferWidth;
			set => Console.BufferWidth = value;
		}

		/// <summary>
		/// Gets a value indicating whether the CAPS LOCK keyboard toggle is turned on or turned off.
		/// </summary>
		/// <value><c>true</c> if CAPS LOCK is turned on; <c>false</c> if CAPS LOCK is turned off.</value>
		/// <seealso cref="Console.CapsLock"/>
		public static bool CapsLock
		{
			get => Console.CapsLock;
		}

		/// <summary>
		/// Gets or sets the column position of the cursor within the buffer area.
		/// </summary>
		/// <value>The current position, in columns, of the cursor.</value>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is less than zero. </exception>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is greater than or equal to <see cref="BufferWidth"/>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.CursorLeft"/>
		public static int CursorLeft
		{
			get => Console.CursorLeft;
			set => Console.CursorLeft = value;
		}

		/// <summary>
		/// Gets or sets the height of the cursor within a character cell.
		/// </summary>
		/// <value>The size of the cursor expressed as a percentage of the height of a character cell. The property value ranges from 1 to 100.</value>
		/// <exception cref="ArgumentOutOfRangeException">The value specified in a set operation is less than 1 or greater than 100.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.CursorSize"/>
		public static int CursorSize
		{
			get => Console.CursorSize;
			set => Console.CursorSize = value;
		}

		/// <summary>
		/// Gets or sets the row position of the cursor within the buffer area.
		/// </summary>
		/// <value>The current position, in rows, of the cursor.</value>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is less than zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The value in a set operation is greater than or equal to <see cref="BufferHeight"/>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.CursorTop"/>
		public static int CursorTop
		{
			get => Console.CursorTop;
			set => Console.CursorTop = value;
		}

		/// <summary>
		/// Gets or sets a value indicating whether the cursor is visible.
		/// </summary>
		/// <value><c>true</c> if the cursor is visible; otherwise, <c>false</c>.</value>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.CursorVisible"/>
		public static bool CursorVisible
		{
			get => Console.CursorVisible;
			set => Console.CursorVisible = value;
		}

		/// <summary>
		/// Gets the standard error output stream.
		/// </summary>
		/// <value>A <see cref="System.IO.TextWriter"/> that represents the standard error output stream.</value>
		/// <seealso cref="Console.Error"/>
		public static System.IO.TextWriter Error
		{
			get => Console.Error;
		}

		/// <summary>
		/// Gets or sets the foreground color of the console.
		/// </summary>
		/// <value>
		/// A <see cref="ConsoleColor"/> that specifies the foreground color of the console; that is, the color of each character that is displayed. The default is <see cref="ConsoleColor.Gray"/>.
		/// </value>
		/// <exception cref="ArgumentException">The color specified in a set operation is not a valid member of <see cref="ConsoleColor"/>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.ForegroundColor"/>
		public static ConsoleColor ForegroundColor
		{
			get => Console.ForegroundColor;
			set => Console.ForegroundColor = value;
		}

		/// <summary>
		/// Gets the standard input stream.
		/// </summary>
		/// <value>A <see cref="System.IO.TextReader"/> that represents the standard input stream.</value>
		/// <seealso cref="Console.In"/>
		public static System.IO.TextReader In
		{
			get => Console.In;
		}

		/// <summary>
		/// Gets or sets the encoding the console uses to read input.
		/// </summary>
		/// <value>The encoding used to read console input.</value>
		/// <exception cref="ArgumentNullException">The property value in a set operation is <c>null</c>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.InputEncoding"/>
		public static System.Text.Encoding InputEncoding
		{
			get => Console.InputEncoding;
			set => Console.InputEncoding = value;
		}

		/// <summary>
		/// Gets a value that indicates whether the error output stream has been redirected from the standard error stream.
		/// </summary>
		/// <value><c>true</c> if error output is redirected; otherwise, <c>false</c>.</value>
		/// <seealso cref="Console.IsErrorRedirected"/>
		public static bool IsErrorRedirected
		{
			get => Console.IsErrorRedirected;
		}

		/// <summary>
		/// Gets a value that indicates whether input has been redirected from the standard input stream.
		/// </summary>
		/// <value><c>true</c> if input is redirected; otherwise, <c>false</c>.</value>
		/// <seealso cref="Console.IsInputRedirected"/>
		public static bool IsInputRedirected
		{
			get => Console.IsInputRedirected;
		}

		/// <summary>
		/// Gets a value that indicates whether output has been redirected from the standard output stream.
		/// </summary>
		/// <value><c>true</c> if output is redirected; otherwise, <c>false</c>.</value>
		/// <seealso cref="Console.IsOutputRedirected"/>
		public static bool IsOutputRedirected
		{
			get => Console.IsOutputRedirected;
		}

		/// <summary>
		/// Gets a value indicating whether a key press is available in the input stream.
		/// </summary>
		/// <value><c>true</c> if a key press is available; otherwise, <c>false</c>.</value>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="InvalidOperationException">Standard input is redirected to a file instead of the keyboard.</exception>
		/// <seealso cref="Console.KeyAvailable"/>
		public static bool KeyAvailable
		{
			get => Console.KeyAvailable;
		}

		/// <summary>
		/// Gets the largest possible number of console window rows, based on the current font and screen resolution.
		/// </summary>
		/// <value>The height of the largest possible console window measured in rows.</value>
		/// <seealso cref="Console.LargestWindowHeight"/>
		public static int LargestWindowHeight
		{
			get => Console.LargestWindowHeight;
		}

		/// <summary>
		/// Gets the largest possible number of console window columns, based on the current font and screen resolution.
		/// </summary>
		/// <value>The width of the largest possible console window measured in columns.</value>
		/// <seealso cref="Console.LargestWindowWidth"/>
		public static int LargestWindowWidth
		{
			get => Console.LargestWindowWidth;
		}

		/// <summary>
		/// Gets a value indicating whether the NUM LOCK keyboard toggle is turned on or turned off.
		/// </summary>
		/// <value><c>true</c> if NUM LOCK is turned on; <c>false</c> if NUM LOCK is turned off.</value>
		/// <seealso cref="Console.NumberLock"/>
		public static bool NumberLock
		{
			get => Console.NumberLock;
		}

		/// <summary>
		/// Gets the standard output stream.
		/// </summary>
		/// <value>A <see cref="System.IO.TextWriter"/> that represents the standard output stream.</value>
		/// <seealso cref="Console.Out"/>
		public static System.IO.TextWriter Out
		{
			get => Console.Out;
		}

		/// <summary>
		/// Gets or sets the encoding the console uses to write output.
		/// </summary>
		/// <value>The encoding used to write console output.</value>
		/// <exception cref="ArgumentNullException">The property value in a set operation is <c>null</c>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.OutputEncoding"/>
		public static System.Text.Encoding OutputEncoding
		{
			get => Console.OutputEncoding;
			set => Console.OutputEncoding = value;
		}

		/// <summary>
		/// Gets or sets the title to display in the console title bar.
		/// </summary>
		/// <value>The string to be displayed in the title bar of the console. The maximum length of the title string is 24500 characters.</value>
		/// <exception cref="InvalidOperationException">In a get operation, the retrieved title is longer than 24500 characters.</exception>
		/// <exception cref="ArgumentOutOfRangeException">In a set operation, the specified title is longer than 24500 characters.</exception>
		/// <exception cref="ArgumentNullException">In a set operation, the specified title is <c>null</c>.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Title"/>
		public static string Title
		{
			get => Console.Title;
			set => Console.Title = value;
		}

		/// <summary>
		/// Gets or sets a value indicating whether the combination of the <see cref="ConsoleModifiers.Control"/> modifier key and <see cref="ConsoleKey.C"/> console key (Ctrl+C) is treated as ordinary input or as an interruption that is handled by the operating system.
		/// </summary>
		/// <value><c>true</c> if Ctrl+C is treated as ordinary input; otherwise, <c>false</c>.</value>
		/// <exception cref="System.IO.IOException">Unable to get or set the input mode of the console input buffer.</exception>
		/// <seealso cref="Console.TreatControlCAsInput"/>
		public static bool TreatControlCAsInput
		{
			get => Console.TreatControlCAsInput;
			set => Console.TreatControlCAsInput = value;
		}

		/// <summary>
		/// Gets or sets the height of the console window area.
		/// </summary>
		/// <value>The height of the console window measured in rows.</value>
		/// <exception cref="ArgumentOutOfRangeException">
		/// The value of the <see cref="WindowWidth"/> property or the value of the <see cref="WindowHeight"/> property is less than or equal to 0.
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// The value of the <see cref="WindowHeight"/> property plus the value of the <see cref="WindowTop"/> property is greater than or equal to <see cref="Int16.MaxValue"/>.
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// The value of the <see cref="WindowWidth"/> property or the value of the <see cref="WindowHeight"/> property is greater than the largest possible window width or height for the current screen resolution and console font.
		/// </exception>
		/// <exception cref="System.IO.IOException">Error reading or writing information.</exception>
		/// <seealso cref="Console.WindowHeight"/>
		public static int WindowHeight
		{
			get => Console.WindowHeight;
			set => Console.WindowHeight = value;
		}

		/// <summary>
		/// Gets or sets the leftmost position of the console window area relative to the screen buffer.
		/// </summary>
		/// <value>The leftmost console window position measured in columns.</value>
		/// <exception cref="ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException">As a result of the assignment, <see cref="WindowLeft"/> plus <see cref="WindowWidth"/> would exceed <see cref="BufferWidth"/>.</exception>
		/// <exception cref="System.IO.IOException">Error reading or writing information.</exception>
		/// <seealso cref="Console.WindowLeft"/>
		public static int WindowLeft
		{
			get => Console.WindowLeft;
			set => Console.WindowLeft = value;
		}

		/// <summary>
		/// Gets or sets the top position of the console window area relative to the screen buffer.
		/// </summary>
		/// <value>The uppermost console window position measured in rows.</value>
		/// <exception cref="ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException">As a result of the assignment, <see cref="WindowTop"/> plus <see cref="WindowHeight"/> would exceed <see cref="BufferHeight"/>.</exception>
		/// <exception cref="System.IO.IOException">Error reading or writing information.</exception>
		/// <seealso cref="Console.WindowTop"/>
		public static int WindowTop
		{
			get => Console.WindowTop;
			set => Console.WindowTop = value;
		}

		/// <summary>
		/// Gets or sets the width of the console window.
		/// </summary>
		/// <value>The width of the console window measured in columns.</value>
		/// <exception cref="ArgumentOutOfRangeException">
		/// The value of the <see cref="WindowWidth"/> property or the value of the <see cref="WindowHeight"/> property is less than or equal to 0.
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// The value of the <see cref="WindowHeight"/> property plus the value of the <see cref="WindowTop"/> property is greater than or equal to <see cref="Int16.MaxValue"/>.
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// The value of <see cref="WindowWidth"/> property or the value of the <see cref="WindowHeight"/> property is greater than the largest possible window width or height for the current screen resolution and console font.
		/// </exception>
		/// <exception cref="System.IO.IOException">Error reading or writing information.</exception>
		/// <seealso cref="Console.WindowWidth"/>
		public static int WindowWidth
		{
			get => Console.WindowWidth;
			set => Console.WindowWidth = value;
		}
		#endregion

		#region Wrapper Methods
		/// <summary>
		///  Plays the sound of a beep through the console speaker.
		/// </summary>
		/// <exception> System.Security.HostProtectionException This method was executed on a server, such as SQL Server, that does not permit access to a user interface.</exception>
		/// <remarks>
		/// <para>By default, the beep plays at a frequency of 800 hertz for a duration of 200 milliseconds.</para>
		/// <para>The <see cref="Beep()"/> method is not supported on the 64-bit editions of Windows Vista and Windows XP. </para>
		/// <para><see cref="Beep()"/> wraps a call to the Windows Beep function. Whether <see cref="Beep()"/> produces a sound on versions of Windows before Windows 7 depends on the presence of a 8254 programmable interval timer chip. Starting with Windows 7, it depends on the default sound device.</para>
		/// </remarks>
		/// <seealso cref="Console.Beep()"/>
		public static void Beep()
		{
			Console.Beep();
		}

		/// <summary>
		/// Plays the sound of a beep of a specified frequency and duration through the console speaker.
		/// </summary>
		/// <param name="frequency">The frequency of the beep, ranging from 37 to 32767 hertz.</param>
		/// <param name="duration">The duration of the beep measured in milliseconds.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="frequency"/> is less than 37 or more than 32767 hertz.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="duration"/> is less than or equal to zero.</exception>
		/// <exception> System.Security.HostProtectionException This method was executed on a server, such as SQL Server, that does not permit access to the console.</exception>
		/// <remarks>
		/// <para><see cref="Beep(int, int)"/> wraps a call to the Windows Beep function. Whether <see cref="Beep(int, int)"/> produces a sound on versions of Windows before Windows 7 depends on the presence of a 8254 programmable interval timer chip. Starting with Windows 7, it depends on the default sound device.</para>
		/// <para>The <see cref="Beep(int, int)"/> method is not supported on the 64-bit editions of Windows Vista and Windows XP.</para>
		/// </remarks>
		/// <seealso cref="Console.Beep(int, int)"/>
		public static void Beep(int frequency, int duration)
		{
			Console.Beep(frequency, duration);
		}

		/// <summary>
		/// Clears the console buffer and corresponding console window of display information.
		/// </summary>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <remarks>
		/// <para>Using the <see cref="Clear"/> method is equivalent invoking the MS-DOS <c>cls</c> command in the command prompt window. When the <see cref="Clear"/> method is called, the cursor automatically scrolls to the top-left corner of the window and the contents of the screen buffer are set to blanks using the current foreground background colors.</para>
		/// <para>Attempting to call the <see cref="Clear"/> method when a console application's output is redirected to a file throws a IOException. To prevent this, always wrap a call to the Clear method in a <c>try</c>…<c>catch</c> block.</para>
		/// </remarks>
		/// <seealso cref="Console.Clear"/>
		public static void Clear()
		{
			Console.Clear();
		}

		/// <summary>
		/// Copies a specified source area of the screen buffer to a specified destination area.
		/// </summary>
		/// <param name="sourceLeft">The leftmost column of the source area.</param>
		/// <param name="sourceTop">The topmost row of the source area.</param>
		/// <param name="sourceWidth">The number of columns in the source area.</param>
		/// <param name="sourceHeight">The number of rows in the source area.</param>
		/// <param name="targetLeft">The leftmost column of the destination area.</param>
		/// <param name="targetTop">The topmost row of the destination area.</param>
		/// <exception cref="ArgumentOutOfRangeException">One or more of the parameters is less than zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="sourceLeft"/> or <paramref name="targetLeft"/> is greater than or equal to <see cref="BufferWidth"/></exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="sourceTop"/> or <paramref name="targetTop"/> is greater than or equal to <see cref="BufferHeight"/></exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="sourceTop"/> + <paramref name="sourceHeight"/> is greater than or equal to <see cref="BufferHeight"/></exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="sourceLeft"/> + <paramref name="sourceWidth"/> is greater than or equal to <see cref="BufferWidth"/></exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <remarks>
		/// <para>
		/// If the destination and source parameters specify a position located outside the boundaries of the current screen buffer, only the portion of the source area that fits within the destination area is copied. That is, the source area is clipped to fit the current screen buffer. 
		/// </para>
		/// <para>
		/// The <see cref="MoveBufferArea(int, int, int, int, int, int)"/> method copies the source area to the destination area. If the destination area does not intersect the source area, the source area is filled with blanks using the current foreground and background colors. Otherwise, the intersected portion of the source area is not filled.
		/// </para>
		/// </remarks>
		/// <seealso cref="Console.MoveBufferArea(int, int, int, int, int, int)"/>
		public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
		{
			Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
		}

		/// <summary>
		/// Copies a specified source area of the screen buffer to a specified destination area.
		/// </summary>
		/// <param name="sourceLeft">The leftmost column of the source area.</param>
		/// <param name="sourceTop">The topmost row of the source area.</param>
		/// <param name="sourceWidth">The number of columns in the source area.</param>
		/// <param name="sourceHeight">The number of rows in the source area.</param>
		/// <param name="targetLeft">The leftmost column of the destination area.</param>
		/// <param name="targetTop">The topmost row of the destination area.</param>
		/// <param name="sourceChar">The character used to fill the source area.</param>
		/// <param name="sourceForeColor">The foreground color used to fill the source area.</param>
		/// <param name="sourceBackColor">The background color used to fill the source area.</param>
		/// <exception cref="ArgumentOutOfRangeException">One or more of the parameters is less than zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="sourceLeft"/> or <paramref name="targetLeft"/> is greater than or equal to <see cref="BufferWidth"/></exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="sourceTop"/> or <paramref name="targetTop"/> is greater than or equal to <see cref="BufferHeight"/></exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="sourceTop"/> + <paramref name="sourceHeight"/> is greater than or equal to <see cref="BufferHeight"/></exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="sourceLeft"/> + <paramref name="sourceWidth"/> is greater than or equal to <see cref="BufferWidth"/></exception>
		/// <exception cref="ArgumentException">One or both of the color parameters is not a member of the <see cref="ConsoleColor"/> enumeration.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <remarks>
		/// <para>
		/// If the destination and source parameters specify a position located beyond the boundaries of the current screen buffer, only the portion of the source area that fits within the destination area is copied. That is, the source area is clipped to fit the current screen buffer. 
		/// </para>
		/// <para>
		/// The <see cref="MoveBufferArea(int, int, int, int, int, int, char, ConsoleColor, ConsoleColor)"/> method copies the source area to the destination area. If the destination area does not intersect the source area, the source area is filled with the character specified by <paramref name="sourceChar"/>, using the colors specified by <paramref name="sourceForeColor"/> and <paramref name="sourceBackColor"/>. Otherwise, the intersected portion of the source area is not filled. 
		/// </para>
		/// <para>
		/// The <see cref="MoveBufferArea(int, int, int, int, int, int, char, ConsoleColor, ConsoleColor)"/> method performs no operation if <paramref name="sourceWidth"/> or <paramref name="sourceHeight"/> is zero.
		/// </para>
		/// </remarks>
		/// <seealso cref="Console.MoveBufferArea(int, int, int, int, int, int, char, ConsoleColor, ConsoleColor)"/>
		public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
		{
			Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
		}

		/// <summary>
		/// Acquires the standard error stream.
		/// </summary>
		/// <returns>The standard error stream.</returns>
		/// <remarks>
		/// This method can be used to reacquire the standard error stream after it has been changed by the <see cref="SetError"/> method.
		/// <seealso cref="Error"/>
		/// <seealso cref="IsErrorRedirected"/>
		/// <seealso cref="SetError(System.IO.TextWriter)"/>
		/// </remarks>
		/// <seealso cref="Console.OpenStandardError()"/>
		public static System.IO.Stream OpenStandardError()
		{
			return Console.OpenStandardError();
		}

		/// <summary>
		/// Acquires the standard error stream, which is set to a specified buffer size.
		/// </summary>
		/// <param name="bufferSize">The internal stream buffer size.</param>
		/// <returns>The standard error stream.</returns>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than or equal to zero.</exception>
		/// <remarks>
		/// This method can be used to reacquire the standard error stream after it has been changed by the <see cref="SetError"/> method.
		/// <seealso cref="Error"/>
		/// <seealso cref="IsErrorRedirected"/>
		/// <seealso cref="SetError(System.IO.TextWriter)"/>
		/// </remarks>
		/// <seealso cref="Console.OpenStandardError(int)"/>
		public static System.IO.Stream OpenStandardError(int bufferSize)
		{
			return Console.OpenStandardError(bufferSize);
		}

		/// <summary>
		/// Acquires the standard input stream.
		/// </summary>
		/// <returns>The standard input stream.</returns>
		/// <remarks>
		/// This method can be used to reacquire the standard input stream after it has been changed by the SetIn method.
		/// <seealso cref="In"/>
		/// <seealso cref="IsInputRedirected"/>
		/// <seealso cref="SetIn(System.IO.TextReader)"/>
		/// </remarks>
		/// <seealso cref="Console.OpenStandardInput()"/>
		public static System.IO.Stream OpenStandardInput()
		{
			return Console.OpenStandardInput();
		}

		/// <summary>
		/// Acquires the standard input stream, which is set to a specified buffer size.
		/// </summary>
		/// <param name="bufferSize">The internal stream buffer size.</param>
		/// <returns>The standard input stream.</returns>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than or equal to zero.</exception>
		/// <remarks>
		/// This method can be used to reacquire the standard output stream after it has been changed by the <see cref="SetIn(System.IO.TextReader)"/> method.
		/// <seealso cref="In"/>
		/// <seealso cref="IsInputRedirected"/>
		/// <seealso cref="SetIn(System.IO.TextReader)"/>
		/// </remarks>
		public static System.IO.Stream OpenStandardInput(int bufferSize)
		{
			return Console.OpenStandardInput(bufferSize);
		}

		/// <summary>
		/// Acquires the standard output stream.
		/// </summary>
		/// <returns>The standard output stream.</returns>
		/// <remarks>
		/// This method can be used to reacquire the standard output stream after it has been changed by the <see cref="SetOut(System.IO.TextWriter)"/> method.
		/// <seealso cref="Out"/>
		/// <seealso cref="IsOutputRedirected"/>
		/// <seealso cref="SetOut(System.IO.TextWriter)"/>
		/// </remarks>
		/// <seealso cref="Console.OpenStandardOutput()"/>
		public static System.IO.Stream OpenStandardOutput()
		{
			return Console.OpenStandardOutput();
		}

		/// <summary>
		/// Acquires the standard output stream, which is set to a specified buffer size.
		/// </summary>
		/// <param name="bufferSize">The internal stream buffer size.</param>
		/// <returns>The standard output stream.</returns>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than or equal to zero.</exception>
		/// <remarks>
		/// This method can be used to reacquire the standard output stream after it has been changed by the <see cref="SetOut(System.IO.TextWriter)"/> method.
		/// <seealso cref="Out"/>
		/// <seealso cref="IsOutputRedirected"/>
		/// <seealso cref="SetOut(System.IO.TextWriter)"/>
		/// </remarks>
		/// <seealso cref="Console.OpenStandardOutput(int)"/>
		public static System.IO.Stream OpenStandardOutput(int bufferSize)
		{
			return Console.OpenStandardOutput(bufferSize);
		}

		/// <summary>
		/// Reads the next character from the standard input stream.
		/// </summary>
		/// <returns>The next character from the input stream, or negative one (-1) if there are currently no more characters to be read.</returns>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <remarks>
		/// <para>
		/// The <see cref="Read"/> method blocks its return while you type input characters; it terminates when you press the <see cref="ConsoleKey.Enter"/> key. Pressing Enter appends a platform-dependent line termination sequence to your input (for example, Windows appends a carriage return-linefeed sequence). Subsequent calls to the <see cref="Read"/> method retrieve your input one character at a time. After the final character is retrieved, <see cref="Read"/> blocks its return again and the cycle repeats. 
		/// </para>
		/// <para>
		/// The <see cref="ReadLine"/> method, or the <see cref="KeyAvailable"/> property and <see cref="ReadKey()"/> method are preferable to using the <see cref="Read"/> method.
		/// </para>
		/// <para>
		/// Note that the method does not return -1 unless you perform one of the following actions: 
		/// <list type="bullet">
		/// <item>
		/// <description>
		/// Simultaneously press the <see cref="ConsoleModifiers.Control"/> modifier key and <see cref="ConsoleKey.Z"/> console key (Ctrl+Z), which signals the end-of-file condition.
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// Press an equivalent key that signals the end-of-file condition, such as the F6 function key in Windows. 
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// Redirect the input stream to a source, such as a text file, that has an actual end-of-file character.
		/// </description>
		/// </item>
		/// </list>
		/// </para>
		/// </remarks>
		/// <seealso cref="Console.Read"/>
		/// <seealso cref="ReadLine"/>
		/// <seealso cref="Write(String, object)"/>
		/// <seealso cref="WriteLine()"/>
		public static int Read()
		{
			return Console.Read();
		}

		/// <summary>
		/// Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.
		/// </summary>
		/// <returns>
		/// An object that describes the <see cref="ConsoleKey"/> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="ConsoleKeyInfo"/> object also describes, in a bitwise combination of <see cref="ConsoleModifiers"/> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.
		/// </returns>
		/// <exception cref="InvalidOperationException">The <see cref="In"/> property is redirected from some stream other than the console.</exception>
		/// <seealso cref="Console.ReadKey()"/>
		public static ConsoleKeyInfo ReadKey()
		{
			return Console.ReadKey();
		}

		/// <summary>
		/// Obtains the next character or function key pressed by the user. The pressed key is optionally displayed in the console window.
		/// </summary>
		/// <param name="intercept">Determines whether to display the pressed key in the console window. <c>true</c> to not display the pressed key; otherwise, <c>false</c>.</param>
		/// <returns>
		/// An object that describes the <see cref="ConsoleKey"/> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="ConsoleKeyInfo"/> object also describes, in a bitwise combination of <see cref="ConsoleModifiers"/> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.
		/// </returns>
		/// <exception cref="InvalidOperationException">The <see cref="In"/> property is redirected from some stream other than the console.</exception>
		/// <seealso cref="Console.ReadKey(bool)"/>
		public static ConsoleKeyInfo ReadKey(bool intercept)
		{
			return Console.ReadKey(intercept);
		}

		/// <summary>
		/// Reads the next line of characters from the standard input stream.
		/// </summary>
		/// <returns>The next line of characters from the input stream, or <c>null</c> if no more lines are available.</returns>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The number of characters in the next line of characters is greater than <see cref="int.MaxValue"/>.</exception>
		/// <seealso cref="Console.ReadLine"/>
		public static string ReadLine()
		{
			return Console.ReadLine();
		}

		/// <summary>
		/// Sets the foreground and background console colors to their defaults.
		/// </summary>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.ResetColor"/>
		public static void ResetColor()
		{
			Console.ResetColor();
		}

		/// <summary>
		/// Sets the height and width of the screen buffer area to the specified values.
		/// </summary>
		/// <param name="width">The width of the buffer area measured in columns.</param>
		/// <param name="height">The height of the buffer area measured in rows.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="height"/> or <paramref name="width"/> is less than or equal to zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="height"/> or <paramref name="width"/> is greater than or equal to <see cref="int.MaxValue"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="width"/> is less than <see cref="WindowLeft"/> + <see cref="WindowWidth"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="height"/> is less than <see cref="WindowTop"/> + <see cref="WindowHeight"/>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.SetBufferSize(int, int)"/>
		public static void SetBufferSize(int width, int height)
		{
			Console.SetBufferSize(width, height);
		}

		/// <summary>
		/// Sets the position of the cursor.
		/// </summary>
		/// <param name="left">The column position of the cursor. Columns are numbered from left to right starting at 0.</param>
		/// <param name="top">The row position of the cursor. Rows are numbered from top to bottom starting at 0.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="left"/> or <paramref name="top"/> is less than zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="left"/> is greater than or equal to <see cref="BufferWidth"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="top"/> is greater than or equal to <see cref="BufferHeight"/>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		public static void SetCursorPosition(int left, int top)
		{
			Console.SetCursorPosition(left, top);
		}

		/// <summary>
		/// Sets the <see cref="Error"/> property to the specified <see cref="System.IO.TextWriter"/> object.
		/// </summary>
		/// <param name="newError">A stream that is the new standard error output.</param>
		/// <exception cref="ArgumentNullException"><paramref name="newError"/> is <c>null</c>.</exception>
		/// <exception cref="System.Security.SecurityException">The caller does not have the required permission.</exception>
		/// <remarks>
		/// <para>By default, the <see cref="Error"/> property is set to the standard error output stream.</para>
		/// <para>A <see cref="System.IO.StreamWriter"/> that encapsulates a <see cref="System.IO.FileStream"/> can be used to send error messages to a file.</para>
		/// </remarks>
		/// <seealso cref="Console.SetError(System.IO.TextWriter)"/>
		/// <seealso cref="IsErrorRedirected"/>
		/// <seealso cref="Error"/>
		public static void SetError(System.IO.TextWriter newError)
		{
			Console.SetError(newError);
		}

		/// <summary>
		/// Sets the <see cref="In"/> property to the specified <see cref="System.IO.TextReader"/> object.
		/// </summary>
		/// <param name="newIn">A stream that is the new standard input.</param>
		/// <exception cref="ArgumentNullException"><paramref name="newIn"/> is <c>null</c>.</exception>
		/// <exception cref="System.Security.SecurityException">The caller does not have the required permission.</exception>
		/// <remarks>
		/// <para>By default, the <see cref="In"/> property is set to the standard input stream.</para>
		/// <para>A <see cref="System.IO.StreamReader"/> that encapsulates a <see cref="System.IO.FileStream"/> can be used to receive input from a file.</para>
		/// </remarks>
		/// <seealso cref="Console.SetIn(System.IO.TextReader)"/>
		/// <seealso cref="System.IO.TextReader"/>
		/// <seealso cref="In"/>
		public static void SetIn(System.IO.TextReader newIn)
		{
			Console.SetIn(newIn);
		}

		/// <summary>
		/// Sets the <see cref="Out"/> property to the specified <see cref="System.IO.TextWriter"/> object.
		/// </summary>
		/// <param name="newOut">A stream that is the new standard output.</param>
		/// <exception cref="ArgumentNullException"><paramref name="newOut"/> is <c>null</c>.</exception>
		/// <exception cref="System.Security.SecurityException">The caller does not have the required permission.</exception>
		/// <remarks>
		/// <para>By default, the <see cref="Out"/> property is set to the standard output stream.</para>
		/// <para>A <see cref="System.IO.StreamWriter"/> that encapsulates a <see cref="System.IO.FileStream"/> can be used to send output to a file.</para>
		/// </remarks>
		/// <seealso cref="Console.SetOut(System.IO.TextWriter)"/>
		/// <seealso cref="System.IO.TextWriter"/>
		/// <seealso cref="Out"/>
		public static void SetOut(System.IO.TextWriter newOut)
		{
			Console.SetOut(newOut);
		}

		/// <summary>
		/// Sets the position of the console window relative to the screen buffer.
		/// </summary>
		/// <param name="left">The column position of the upper left corner of the console window.</param>
		/// <param name="top">The row position of the upper left corner of the console window.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="left"/> or <paramref name="top"/> is less than zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="left"/> + <see cref="WindowWidth"/> is greater than <see cref="BufferWidth"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="top"/> + <see cref="WindowHeight"/> is greater than <see cref="BufferHeight"/>.</exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.SetWindowPosition(int, int)"/>
		public static void SetWindowPosition(int left, int top)
		{
			Console.SetWindowPosition(left, top);
		}

		/// <summary>
		/// Sets the height and width of the console window to the specified values.
		/// </summary>
		/// <param name="width">The width of the console window measured in columns.</param>
		/// <param name="height">The height of the console window measured in rows.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="width"/> or <paramref name="height"/> is less than or equal to zero.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="width"/> + <see cref="WindowLeft"/> or <paramref name="height"/> + <see cref="WindowTop"/> is greater than or equal to <see cref="Int16.MaxValue"/>
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="width"/> or <paramref name="height"/> is greater than the largest possible window width or height for the current screen resolution and console font.
		/// </exception>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.SetWindowSize(int, int)"/>
		public static void SetWindowSize(int width, int height)
		{
			Console.SetWindowSize(width, height);
		}

		#region Write
		/// <summary>
		/// Writes the text representation of the specified objects and variable-length parameter list to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <param name="arg1">The second object to write using <paramref name="format"/>.</param>
		/// <param name="arg2">The third object to write using <paramref name="format"/>.</param>
		/// <param name="arg3">The fourth object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.Write(string, object, object, object)"/>
		[System.CLSCompliant(false)]
		public static void Write(string format, object arg0, object arg1, object arg2, object arg3)
		{
			Console.Write(format, arg0, arg1, arg2, arg3);
		}

		/// <summary>
		/// Writes the text representation of the specified objects to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <param name="arg1">The second object to write using <paramref name="format"/>.</param>
		/// <param name="arg2">The third object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.Write(string, object, object, object)"/>
		public static void Write(string format, object arg0, object arg1, object arg2)
		{
			Console.Write(format, arg0, arg1, arg2);
		}

		/// <summary>
		/// Writes the text representation of the specified objects to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <param name="arg1">The second object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.Write(string, object, object)"/>
		public static void Write(string format, object arg0, object arg1)
		{
			Console.Write(format, arg0, arg1);
		}

		/// <summary>
		/// Writes the text representation of the specified array of objects to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg">An array of objects to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> or <paramref name="arg"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.Write(string, object[])"/>
		public static void Write(string format, params object[] arg)
		{
			Console.Write(format, arg);
		}

		/// <summary>
		/// Writes the text representation of the specified objects to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.Write(string, object)"/>
		public static void Write(string format, object arg0)
		{
			Console.Write(format, arg0);
		}

		/// <summary>
		/// Writes the text representation of the specified 64-bit unsigned integer value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(ulong)"/>
		[System.CLSCompliant(false)]
		public static void Write(ulong value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the text representation of the specified 32-bit unsigned integer value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(uint)"/>
		[System.CLSCompliant(false)]
		public static void Write(uint value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the specified string value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(string)"/>
		public static void Write(string value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the specified subarray of Unicode characters to the standard output stream.
		/// </summary>
		/// <param name="buffer">An array of Unicode characters.</param>
		/// <param name="index">The starting position in <paramref name="buffer"/>.</param>
		/// <param name="count">The number of characters to write.</param>
		/// <exception cref="ArgumentNullException"><paramref name="buffer"/> is <c>null</c>.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> + <paramref name="count"/> specify a position that is not within <paramref name="buffer"/>.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(char[], int, int)"/>
		public static void Write(char[] buffer, int index, int count)
		{
			Console.Write(buffer, index, count);
		}

		/// <summary>
		/// Writes the text representation of the specified object to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write, or <c>null</c>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(object)"/>
		public static void Write(object value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the text representation of the specified single-precision floating-point value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(float)"/>
		public static void Write(float value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the specified Unicode character value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(char)"/>
		public static void Write(char value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the specified array of Unicode characters to the standard output stream.
		/// </summary>
		/// <param name="buffer">A Unicode character array.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(char[])"/>
		public static void Write(char[] buffer)
		{
			Console.Write(buffer);
		}

		/// <summary>
		/// Writes the text representation of the specified Boolean value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(bool)"/>
		public static void Write(bool value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the text representation of the specified double-precision floating-point value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(double)"/>
		public static void Write(double value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the text representation of the specified 32-bit signed integer value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(int)"/>
		public static void Write(int value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the text representation of the specified 64-bit signed integer value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(long)"/>
		public static void Write(long value)
		{
			Console.Write(value);
		}

		/// <summary>
		/// Writes the text representation of the specified <see cref="decimal"/> value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.Write(decimal)"/>
		public static void Write(decimal value)
		{
			Console.Write(value);
		}
		#endregion

		#region WriteLine
		/// <summary>
		/// Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <param name="arg1">The first object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.WriteLine(String, object, object)"/>
		public static void WriteLine(string format, object arg0, object arg1)
		{
			Console.WriteLine(format, arg0, arg1);
		}

		/// <summary>
		/// Writes the specified string value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <remarks>
		/// If value is <c>null</c>, only the line terminator is written to the standard output stream.
		/// </remarks>
		/// <seealso cref="Console.WriteLine(String)"/>
		public static void WriteLine(string value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the specified subarray of Unicode characters, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="buffer">An array of Unicode characters.</param>
		/// <param name="index">The starting position in <paramref name="buffer"/>.</param>
		/// <param name="count">The number of characters to write.</param>
		/// <exception cref="ArgumentNullException"><paramref name="buffer"/> is <c>null</c>.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> or <paramref name="count"/> is less than zero.</exception>
		/// <exception cref="ArgumentException"><paramref name="index"/> + <paramref name="count"/> specify a position that is not within <paramref name="buffer"/>.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <remarks>
		/// This method writes <paramref name="count"/> characters starting at position <paramref name="index"/> of <paramref name="buffer"/> to the standard output stream. 
		/// </remarks>
		/// <seealso cref="Console.WriteLine(char[], int, int)"/>
		public static void WriteLine(char[] buffer, int index, int count)
		{
			Console.WriteLine(buffer, index, count);
		}

		/// <summary>
		/// Writes the text representation of the specified array of objects, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg">An array of objects to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> or <paramref name="arg"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.WriteLine(String, object[])"/>
		public static void WriteLine(string format, params object[] arg)
		{
			Console.WriteLine(format, arg);
		}

		/// <summary>
		/// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">An object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="WriteLine(String, object)"/>
		public static void WriteLine(string format, object arg0)
		{
			Console.WriteLine(format, arg0);
		}

		/// <summary>
		/// Writes the text representation of the specified 64-bit unsigned integer value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="WriteLine(Int64)"/>
		[System.CLSCompliant(false)]
		public static void WriteLine(ulong value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the text representation of the specified 32-bit unsigned integer value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(int)"/>
		[CLSCompliant(false)]
		public static void WriteLine(uint value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the text representation of the specified single-precision floating-point value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(float)"/>
		public static void WriteLine(float value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the text representation of the specified <see cref="decimal"/> value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(decimal)"/>
		public static void WriteLine(decimal value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the text representation of the specified 64-bit signed integer value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(long)"/>
		public static void WriteLine(long value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the text representation of the specified 32-bit signed integer value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(int)"/>
		public static void WriteLine(int value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the text representation of the specified double-precision floating-point value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(double)"/>
		public static void WriteLine(double value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the specified array of Unicode characters, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="buffer">A Unicode character array.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(char[])"/>
		public static void WriteLine(char[] buffer)
		{
			Console.WriteLine(buffer);
		}

		/// <summary>
		/// Writes the specified Unicode character, followed by the current line terminator, value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(char)"/>
		public static void WriteLine(char value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the text representation of the specified Boolean value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(bool)"/>
		public static void WriteLine(bool value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the current line terminator to the standard output stream.
		/// </summary>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine()
		{
			Console.WriteLine();
		}

		/// <summary>
		/// Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <param name="arg1">The second object to write using <paramref name="format"/>.</param>
		/// <param name="arg2">The third object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.Write(String, object, object, object)"/>
		public static void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			Console.WriteLine(format, arg0, arg1, arg2);
		}

		/// <summary>
		/// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="Console.WriteLine(object)"/>
		public static void WriteLine(object value)
		{
			Console.WriteLine(value);
		}

		/// <summary>
		/// Writes the text representation of the specified objects and variable-length parameter list, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <param name="arg1">The second object to write using <paramref name="format"/>.</param>
		/// <param name="arg2">The third object to write using <paramref name="format"/>.</param>
		/// <param name="arg3">The fourth object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.WriteLine(string, object, object, object)"/>
		[CLSCompliant(false)]
		public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3)
		{
			Console.WriteLine(format, arg0, arg1, arg2, arg3);
		}
		#endregion

		#endregion

		#region Wrapper Events
		/// <summary>
		/// Occurs when the <see cref="ConsoleModifiers.Control"/> modifier key (Ctrl) and either the <see cref="ConsoleKey.C"/> console key (C) or the Break key are pressed simultaneously (Ctrl+C or Ctrl+Break).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This event is used in conjunction with <see cref="ConsoleCancelEventHandler"/> and <see cref="ConsoleCancelEventArgs"/>. The <see cref="CancelKeyPress"/> event enables a console application to intercept the Ctrl+C signal so the event handler can decide whether to continue executing or terminate. For more information about handling events, see <see href="https://docs.microsoft.com/en-us/dotnet/standard/events/index?view=netframework-4.7.2">Handling and Raising Events</see>. 
		/// </para>
		/// <para>
		/// When the user presses either Ctrl+C or Ctrl+Break, the <see cref="CancelKeyPress"/> event is fired and the application's <see cref="ConsoleCancelEventHandler"/> event handler is executed. The event handler is passed a <see cref="ConsoleCancelEventArgs"/> object that has two useful properties: 
		/// <list type="bullet">
		/// <item>
		/// <description>
		/// <see cref="ConsoleCancelEventArgs.SpecialKey"/>, which allows you to determine whether the handler was invoked as a result of the user pressing Ctrl+C (the property value is <see cref="ConsoleSpecialKey.ControlC"/>) or Ctrl+Break (the property value is <see cref="ConsoleSpecialKey.ControlBreak"/>).
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// <see cref="ConsoleCancelEventArgs.Cancel"/>, which allows you to determine how to your application should respond to the user pressing Ctrl+C or Ctrl+Break. By default, the <see cref="ConsoleCancelEventArgs.Cancel"/> property is <c>false</c>, which causes program execution to terminate when the event handler exits. Changing its property to <c>true</c> specifies that the application should continue to execute. 
		/// </description>
		/// </item>
		/// </list>
		/// </para>
		/// <para>
		/// If your application has simple requirements, you can use the <see cref="TreatControlCAsInput"/> property instead of this event. By setting this property to <c>false</c>, you can ensure that your application always exits if the user presses Ctrl+C. By setting it to <c>true</c>, you can ensure that pressing Ctrl+C will not terminate the application. 
		/// </para>
		/// <para>
		/// The event handler for this event is executed on a thread pool thread.
		/// </para>
		/// </remarks>
		/// <seealso cref="Console.CancelKeyPress"/>
		/// <seealso cref="ConsoleCancelEventArgs"/>
		/// <seealso cref="ConsoleCancelEventHandler"/>
		/// <seealso cref="TreatControlCAsInput"/>
		public static event ConsoleCancelEventHandler CancelKeyPress
		{
			add { Console.CancelKeyPress += value;  }
			remove { Console.CancelKeyPress -= value; }
		}
		#endregion
	}
}
