<%@ Page Language="C#" Inherits="Demo.login" AutoEventWireup="true" CodeFile="login.aspx.cs"%>
<!DOCTYPE html>
<html>
    <head>
        <title>WallStreet DEMO</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" href="assets/css/main.css" />
    </head>
    <body class="subpage">

        <!-- Header -->
            <header id="header">
                <div class="inner">
                    <a href="index.aspx" class="logo"><strong>WallStreet </strong> DEMO</a>
                    <nav id="nav">
                        <a href="index.aspx">Home</a>
                        <a href="login.aspx">Login</a>
                    </nav>
                    <a href="#navPanel" class="navPanelToggle"><span class="fa fa-bars"></span></a>
                </div>
            </header>

		<form id="form1" runat="server">
        <!-- login -->
            <section id="three" class="wrapper">
                <div class="inner">
                    <header class="align-center">
                        <h2>登入 WallStreet</h2>
                        <p>Login to start our service</p>
                    </header>
				
                    <div class="row">
                        <div class="4u 12u$(medium)">
						    <p> </p>
                        </div>
                        <div class="4u 12u$(medium)">
                            <input runat="server" type="text" name="account" id="account" value="" placeholder="ACCOUNT" />
                            <br>
                            <input runat="server" type="password" name="password" id="password" value="" placeholder="PASSWORD" />
						    <br>
                            <ul class="actions">
							    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <li><button id="login_" OnServerClick="login_OnClick" runat="server">登入</button></li>
                                <li><a href="#" class="button">註冊</a></li>
                            </ul>

						
					    </div>
                        <div class="4u 12u$(medium)">
                            <p> </p>
                        </div>
                    </div>

                </div>
            </section>

        <!-- Footer -->
            <footer id="footer">
                <div class="inner">

                    <h3>Get in touch</h3>



                        <div class="field half first">
                            <label for="name">Name</label>
                            <input name="name" id="name" type="text" placeholder="Name">
                        </div>
                        <div class="field half">
                            <label for="email">Email</label>
                            <input name="email" id="email" type="email" placeholder="Email">
                        </div>
                        <div class="field">
                            <label for="message">Message</label>
                            <textarea name="message" id="message" rows="6" placeholder="Message"></textarea>
                        </div>
                        <ul class="actions">
                            <li><input value="Send Message" class="button alt" type="submit"></li>
                        </ul>
                    

                    <div class="copyright">
                        &copy; Untitled. Design: <a href="https://templated.co">TEMPLATED</a>. Images: <a href="https://unsplash.com">Unsplash</a>.
                    </div>

                </div>
            </footer>
            </form>
        <!-- Scripts -->
            <script src="assets/js/jquery.min.js"></script>
            <script src="assets/js/skel.min.js"></script>
            <script src="assets/js/util.js"></script>
            <script src="assets/js/main.js"></script>

    </body>