<%@ Page Language="C#" Inherits="Demo.wallet" %>
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
                        <a href="profit.aspx">Profit</a>
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
                        <h2>My Wallet</h2>
                        <p>管理我的錢包</p>
                    </header>
                        <div class="table-wrapper" style="width:60%;margin:0px auto;">
                        <table class="alt">
                            <thead>
                                <tr>
                                    <th>幣種</th>
                                    <th>擁有數量</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>BTC</td>
                                    <td><asp:Label ID="BTC" runat="server" Text="0.00"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>ETH</td>
                                    <td><asp:Label ID="ETH" runat="server" Text="0.00"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>ZEC</td>
                                    <td><asp:Label ID="ZEC" runat="server" Text="0.00"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>LTC</td>
                                    <td><asp:Label ID="LTC" runat="server" Text="0.00"></asp:Label></td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <td>總額</td>
									<td><asp:Label ID="sum" runat="server" Text="0.00"></asp:Label></td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
						

                    <hr class="major" />

					<header class="align-center">
                        <h3>Deposit 入金</h3>
                        <p>打錢到這些位置</p>
                    </header>

                    <div class="table-wrapper" style="width:65%;margin:0px auto;">
                        <table>
                            <thead>
                                <tr>
                                    <th>幣種</th>
                                    <th>地址</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>BTC</td>
                                    <td><asp:Label ID="BTC_in" runat="server" Text="0.00"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>ETH</td>
                                    <td><asp:Label ID="ETH_in" runat="server" Text="0.00"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>ZEC</td>
                                    <td><asp:Label ID="ZEC_in" runat="server" Text="0.00"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>LTC</td>
                                    <td><asp:Label ID="LTC_in" runat="server" Text="0.00"></asp:Label></td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <td colspan="2"></td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>


                    <hr class="major" />
					<header class="align-center">
                        <h3>Withdraw  出金</h3>
                        <p>取款申請</p>
						<br>
						<br>
						<h2>DEMO狀態無法申請，請聯絡我們取款</h2>
                    </header>

					
                    
                </div>
            </section>

        <!-- Footer -->
            <footer id="footer">
                <div class="inner">

                </div>
            </footer>
            </form>
        <!-- Scripts -->
            <script src="assets/js/jquery.min.js"></script>
            <script src="assets/js/skel.min.js"></script>
            <script src="assets/js/util.js"></script>
            <script src="assets/js/main.js"></script>

    </body>