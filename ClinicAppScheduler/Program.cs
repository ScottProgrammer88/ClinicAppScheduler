namespace ClinicAppScheduler
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

            /// <summary>
            ///  Run the application with the frmPatient form, which is the main form.
			///  This is the form that will be displayed when the application starts.
			///  To change the main form, change frmPatient to the desired form in the parameter.
            /// </summary>
            Application.Run(new frmPatient());
		}
	}
}