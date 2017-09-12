<%@ Page Language="C#" Inherits="Demo.index" AutoEventWireup="true" CodeFile="index.aspx.cs" %>
<html>
    <head>
        <title>WallStreet DEMO</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" href="assets/css/main.css" />
    </head>
    <body>

        <!-- Header -->
            <header id="header">
                <div class="inner">
                    <a href="index.aspx" class="logo"><strong>WallStreet</strong> DEMO</a>
                    <nav id="nav">
                        <a href="index.aspx">Home</a>
                        <a href="login.aspx">Login</a>
                    </nav>
                    <a href="#navPanel" class="navPanelToggle"><span class="fa fa-bars"></span></a>
                </div>
            </header>

        <!-- Banner -->
            <section id="banner">
                <div class="inner">
                    <header>
                        <h1>Welcome to WallStreet</h1>
                    </header>

                    <div class="flex ">

                        <div>
                            <span class="icon fa-cubes"></span>
                            <h3>區塊鏈</h3>
                            <p>為企業導入區塊鏈技術</p>
                        </div>

                        <div>
                            <span class="icon fa-btc"></span>
                            <h3>數字貨幣</h3>
                            <p>最火買&賣最新趨勢</p>
                        </div>

                        <div>
                            <span class="icon fa-refresh"></span>
                            <h3>套利</h3>
                            <p>最簡易的套利平台</p>
                        </div>

                    </div>

                    <footer>
                        <a href="login.aspx" class="button">Get Started</a>
                    </footer>
                </div>
            </section>

        <!-- Footer -->
            <footer id="footer">
                <div class="inner">

                    <h3>Get in touch</h3>

                    <form action="#" method="post">

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
                    </form>


                </div>
            </footer>

        <!-- Scripts -->
            <script src="assets/js/jquery.min.js"></script>
            <script src="assets/js/skel.min.js"></script>
            <script src="assets/js/util.js"></script>
            <script src="assets/js/main.js"></script>

    </body>
</html>
