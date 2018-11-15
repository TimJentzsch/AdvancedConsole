using System;
using System.Collections.Generic;
using System.Text;


namespace AdvancedConsole
{
	/// <summary>
	/// A console with added functionality.
	/// </summary>
	[CLSCompliant(true)]
    public class AdvConsole : BaseConsole
    {
		/// <summary>
		/// Sets the foreground color to its default.
		/// </summary>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		public static void ResetForegroundColor()
		{
			ForegroundColor = ConsoleColor.Gray;
		}

		/// <summary>
		/// Sets the background color to its default.
		/// </summary>
		/// <exception cref="System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		public static void ResetBackgroundColor()
		{
			BackgroundColor = ConsoleColor.Black;
		}

		#region WriteLine
		/// <summary>
		/// Writes the text representation of the specified objects in the specified color, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <param name="arg1">The first object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="BaseConsole.WriteLine(String, object, object)"/>
		public static void WriteLine(ConsoleColor color, string format, object arg0, object arg1)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(format, arg0, arg1);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		///  Writes the specified string value in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <remarks>
		/// <para>If value is <c>null</c>, only the line terminator is written to the standard output stream.</para>
		/// <para>After completing the write oparation, the previously used foreground color gets restored.</para>
		/// </remarks>
		/// <seealso cref="BaseConsole.WriteLine(string)"/>
		public static void WriteLine(ConsoleColor color, string value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the specified subarray of Unicode characters in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
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
		/// <seealso cref="BaseConsole.WriteLine(char[], int, int)"/>
		public static void WriteLine(ConsoleColor color, char[] buffer, int index, int count)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(buffer, index, count);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified array of objects in the specified color, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg">An array of objects to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> or <paramref name="arg"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="BaseConsole.WriteLine(string, object[])"/>
		public static void WriteLine(ConsoleColor color, string format, params object[] arg)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(format, arg);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified object in the specified color, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">An object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="BaseConsole.WriteLine(string, object)"/>
		public static void WriteLine(ConsoleColor color, string format, object arg0)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(format, arg0);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified 64-bit unsigned integer value in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(ulong)"/>
		[CLSCompliant(false)]
		public static void WriteLine(ConsoleColor color, ulong value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified 32-bit unsigned integer value in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(int)"/>
		[CLSCompliant(false)]
		public static void WriteLine(ConsoleColor color, uint value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified single-precision floating-point value in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(float)"/>
		public static void WriteLine(ConsoleColor color, float value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified <see cref="decimal"/> value in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(decimal)"/>
		public static void WriteLine(ConsoleColor color, decimal value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified 64-bit signed integer value in the specified color in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(long)"/>
		public static void WriteLine(ConsoleColor color, long value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified 32-bit signed integer value in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(int)"/>
		public static void WriteLine(ConsoleColor color, int value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified double-precision floating-point value in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(double)"/>
		public static void WriteLine(ConsoleColor color, double value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the specified array of Unicode characters in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="buffer">A Unicode character array.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(char[])"/>
		public static void WriteLine(ConsoleColor color, char[] buffer)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(buffer);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the specified Unicode character in the specified color, followed by the current line terminator, value to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(char)"/>
		public static void WriteLine(ConsoleColor color, char value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified Boolean value in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(bool)"/>
		public static void WriteLine(ConsoleColor color, bool value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified objects in the specified color, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <param name="arg1">The second object to write using <paramref name="format"/>.</param>
		/// <param name="arg2">The third object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="Console.Write(String, object, object, object)"/>
		public static void WriteLine(ConsoleColor color, string format, object arg0, object arg1, object arg2)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(format, arg0, arg1, arg2);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified object in the specified color, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="value">The value to write.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <seealso cref="BaseConsole.WriteLine(object)"/>
		public static void WriteLine(ConsoleColor color, object value)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(value);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		/// <summary>
		/// Writes the text representation of the specified objects and variable-length parameter list in the specified color, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="color">The foreground color to write in.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using <paramref name="format"/>.</param>
		/// <param name="arg1">The second object to write using <paramref name="format"/>.</param>
		/// <param name="arg2">The third object to write using <paramref name="format"/>.</param>
		/// <param name="arg3">The fourth object to write using <paramref name="format"/>.</param>
		/// <exception cref="System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="format"/> is <c>null</c>.</exception>
		/// <exception cref="FormatException">The format specification in <paramref name="format"/> is invalid.</exception>
		/// <seealso cref="BaseConsole.WriteLine(string, object, object, object, object)"/>
		[CLSCompliant(false)]
		public static void WriteLine(ConsoleColor color, string format, object arg0, object arg1, object arg2, object arg3)
		{
			// Save the previous foreground color
			ConsoleColor prevColor = ForegroundColor;
			// Set the foreground color to the specified value
			ForegroundColor = color;

			WriteLine(format, arg0, arg1, arg2, arg3);
			// Restore previous foreground color
			ForegroundColor = prevColor;
		}

		#endregion
	}
}
