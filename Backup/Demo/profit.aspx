<%@ Page Language="C#" Inherits="Demo.profit" AutoEventWireup="true" CodeFile="profit.aspx.cs" %>
<!DOCTYPE html>
<html>
    <head>
        <title>WallStreet DEMO</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" href="assets/css/main.css" />
		<meta http-equiv="refresh" content="5" />
    </head>
    <body class="subpage">

        <!-- Header -->
            <header id="header">
                <div class="inner">
                    <a href="index.aspx" class="logo"><strong>WallStreet </strong> DEMO</a>
                    <nav id="nav">
                        <a href="index.aspx">Home</a>
                        <a href="logout.aspx">Logout</a>
                    </nav>
                    <a href="#navPanel" class="navPanelToggle"><span class="fa fa-bars"></span></a>
                </div>
            </header>

        <form id="form1" runat="server">
        <!-- login -->
            <section id="three" class="wrapper">
                <div class="inner">
                    <header class="align-center">
                        <h2>套利-搬磚</h2>
                        <p>交給我們，最簡易的搬磚系統</p>
                    </header>


					<div class="row">
                            <section class="6u 12u$(medium)">
                                <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Profit Table</h2>

                                <div class="table-wrapper" style="width:80%;margin:0px auto;">
                                <table class="alt">
                                    <thead>
                                        <tr>
                                            <th>交易所</th>
                                            <th>幣種</th>
											<th>利潤</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td><asp:Label ID="exchange1" runat="server" Text=""></asp:Label></td>
                                            <td><asp:Label ID="coin1" runat="server" Text=""></asp:Label></td>
											<td><asp:Label ID="profit1" runat="server" Text=""></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td><asp:Label ID="exchange2" runat="server" Text=""></asp:Label></td>
                                            <td><asp:Label ID="coin2" runat="server" Text=""></asp:Label></td>
											<td><asp:Label ID="profit2" runat="server" Text=""></asp:Label></td>

                                        </tr>
                                        <tr>
                                            <td><asp:Label ID="exchange3" runat="server" Text=""></asp:Label></td>
                                            <td><asp:Label ID="coin3" runat="server" Text=""></asp:Label></td>
											<td><asp:Label ID="profit3" runat="server" Text=""></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td><asp:Label ID="exchange4" runat="server" Text=""></asp:Label></td>
                                            <td><asp:Label ID="coin4" runat="server" Text=""></asp:Label></td>
											<td><asp:Label ID="profit4" runat="server" Text=""></asp:Label></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
							
							    
						    </section>
                            <section class="3u 6u(medium) 12u$(small)">
                                <h3>開始搬磚看這裡</h3>
                                <ul class="actions">
                                        <li><button id="Start" runat="server" class="button special big" OnServerClick="Start_OnClick" >開始搬磚</button></li>
                                        <li> <br>.</li>
								        <li><a href="wallet.aspx" class="button">我的錢包</a></li>
                                </ul>
						    </section>
                            <section class="3u$ 6u$(medium) 12u$(small)">
                                <h3>注意事項</h3>
                                <blockquote>請不要關閉此網頁，DEMO版本為了測試壓力上限及使用人數控制，關閉網頁即停止使用。或是詳見<strong>VIP版本</strong>。</blockquote>
                                <blockquote>最簡易最棒的演算法，省去您天天看著市場的時間，交給我們，立即使用。DEMO_V_0.1.2.2</blockquote>
						    </section>
                        </div>
                   

                </div>
            </section>

        <!-- Footer -->
            <footer id="footer">
               
            </footer>
            </form>
        <!-- Scripts -->
            <script src="assets/js/jquery.min.js"></script>
            <script src="assets/js/skel.min.js"></script>
            <script src="assets/js/util.js"></script>
            <script src="assets/js/main.js"></script>

    </body>
