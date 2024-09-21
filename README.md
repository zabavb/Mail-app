<p align="center">
	<img
		src="https://img.icons8.com/fluency/100/email.png"
		alt="Mail App Logo"
		width="120"
		height="120" />
</p>

<h1 align="center">Mail Application</h1>

<h2>Project Overview</h2>
<p>
	The <strong>Mail Application</strong> is a Windows Forms (WinForms) project
	developed using C# and .NET. This application allows users to send email
	messages after filling out necessary details like SMTP server name, server
	port, email credentials, and recipient information. It also enables users to
	manage their inbox, search for emails by body content, subject, drafts, or
	unseen messages, and delete emails directly from the application.
</p>

<h2>Project Details</h2>
<ul>
	<li>
		<strong>Languages:</strong>
		<a
			href="https://learn.microsoft.com/en-us/dotnet/csharp/"
			target="_blank">
			<img
				src="https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white"
				alt="C#" />
		</a>
	</li>
	<li>
		<strong>Technologies:</strong>
		<a
			href="https://dotnet.microsoft.com/"
			target="_blank">
			<img
				src="https://img.shields.io/badge/.NET-5C2D91?style=flat&logo=.net&logoColor=white"
				alt=".NET" />
		</a>
		<a
			href="https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-7.0"
			target="_blank">
			<img
				src="https://img.shields.io/badge/WinForms-5C2D91?style=flat&logo=windows&logoColor=white"
				alt="WinForms" />
		</a>
	</li>
	<li>
		<strong>IDE:</strong>
		<a
			href="https://visualstudio.microsoft.com/"
			target="_blank">
			<img
				src="https://img.shields.io/badge/Visual%20Studio-5C2D91?style=flat&logo=visual-studio&logoColor=white"
				alt="Visual Studio" />
		</a>
	</li>
</ul>
<h2>Development Details</h2>
<p>
	This project was created on September 27, 2023, as a homework assignment
	from IT Step Academy. It was developed as part of the course to practice
	building email client applications, handling user input, and interacting
	with external servers via SMTP.
</p>
<h2>Important Notice</h2>
<p>
	For security reasons, certain credentials such as SMTP server name, port,
	and email account information have been removed from the project. You will
	need to replace these placeholders with your own details in the
	<code>Settings.cs</code> file on line 21:
</p>
<pre><code> // Startup settings textBoxServer.Text = "[your server name].gmail.com"; textBoxPort.Text = "[your port]"; textBoxName.Text = "[your name]"; textBoxEmail.Text = "[your email]"; textBoxPassword.Text = "[your password]"; textBoxMailBox.Text = "appTest"; checkBoxSSl.Checked = true; </code></pre>
<h2>Getting Started</h2>
<ol>
	<li>
		Clone the repository:
		<pre><code>git clone https://github.com/zabavb/Mail-app.git</code></pre>
	</li>
	<li>
		Navigate to the project directory:
		<pre><code>cd Mail-app</code></pre>
	</li>
	<li>Open the solution file (<code>.sln</code>) in Visual Studio.</li>
	<li>Build and run the application by pressing <code>F5</code>.</li>
</ol>
<h2>Features</h2>
<ul>
	<li>
		<strong>Email Sending:</strong> Allows users to send emails after
		entering SMTP settings and recipient information.
	</li>
	<li>
		<strong>Inbox Management:</strong> View received messages in the inbox,
		with options to search by body, subject, drafts, unseen messages, or
		delete emails.
	</li>
	<li>
		<strong>SMTP Configuration:</strong> Set and save SMTP server details
		and email account credentials in the settings page.
	</li>
</ul>
<h2>Usage</h2>
<p>
	To use the application, you need to correctly configure the SMTP server
	name, port, email credentials, and mailbox in the settings page. After
	setup, use the main window to send emails by filling in the recipient's
	email address, subject, and message body. You can also browse through your
	inbox, search for specific emails, and manage your mailbox efficiently.
</p>
<h2>Contributing</h2>
<p>
	Contributions are welcome! If you have suggestions or improvements, feel
	free to fork the repository and submit a pull request.
</p>
<ol>
	<li>
		Fork the Repository: Click the "Fork" button at the top-right of this
		page.
	</li>
	<li>Create a Branch: Create a new branch for your changes.</li>
	<li>
		Commit Changes: Make your changes and commit them with a descriptive
		message.
	</li>
	<li>Push to Your Fork: Push your changes to your forked repository.</li>
	<li>
		Submit a Pull Request: Go to the "Pull Requests" tab and submit a new
		pull request.
	</li>
</ol>
<h2>Contact</h2>
<p>
	If you have any questions or suggestions, feel free to reach out to me via
	<a href="mailto:bilonizkavik@agmail.com">email</a> or connect with me on
	<a
		href="https://www.linkedin.com/in/viktor-bilonizhka"
		target="_blank"
		>LinkedIn</a
	>.
</p>
<h2>References</h2>
<ul>
	<li>
		<a
			href="https://learn.microsoft.com/en-us/dotnet/"
			target="_blank"
			>.NET Documentation</a
		>
	</li>
	<li>
		<a
			href="https://learn.microsoft.com/en-us/visualstudio/"
			target="_blank"
			>Microsoft Visual Studio Documentation</a
		>
	</li>
	<li>
		<a
			href="https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-7.0"
			target="_blank"
			>WinForms Documentation</a
		>
	</li>
</ul>
<h2>Acknowledgements</h2>
<ul>
	<li>
		Thanks to IT Step Academy for providing guidance and support in
		developing this project.
	</li>
  <li>
    Special thanks to the open-source community for their contributions and resources.
  </li>
</ul>
<hr />
<p align="center">
	Feel free to modify or extend this README to suit your needs. Happy coding!
</p>
