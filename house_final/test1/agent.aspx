<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agent.aspx.cs" Inherits="test1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

     <title>Houseiva|Add Property</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    
    <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:200,300,400,600,700,800,900&display=swap" rel="stylesheet">

    <link rel="stylesheet" href="css/open-iconic-bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
    
    <link rel="stylesheet" href="css/owl.carousel.min.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">
    <link rel="stylesheet" href="css/magnific-popup.css">

    <link rel="stylesheet" href="css/aos.css">

    <link rel="stylesheet" href="css/ionicons.min.css">

    <link rel="stylesheet" href="css/bootstrap-datepicker.css">
    <link rel="stylesheet" href="css/jquery.timepicker.css">

    
    <link rel="stylesheet" href="css/flaticon.css">
    <link rel="stylesheet" href="css/icomoon.css">
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
  
    <form id="form2" runat="server">
     
    
	  
	 <nav class="navbar navbar-expand-lg navbar-dark ftco_navbar bg-dark ftco-navbar-light" id="ftco-navbar">
	    <div class="container">
	      <a class="navbar-brand" href="index.html"></a>
	      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#ftco-nav" aria-controls="ftco-nav" aria-expanded="false" aria-label="Toggle navigation">
	        <span class="oi oi-menu"></span> Menu
	      </button>

	      <div class="collapse navbar-collapse" id="ftco-nav">
	        <ul class="navbar-nav ml-auto">
	          <li class="nav-item active"><a href="home.aspx" class="nav-link">Home</a></li>
      
	          
	          <li class="nav-item"><a href="agent.aspx" class="nav-link">Add Property</a></li>
	     
	          <li class="nav-item"><a href="property.aspx" class="nav-link">Properties</a></li>
	          <li class="nav-item"><a href="view_property.aspx" class="nav-link">Your Properties</a></li>
	          <li class="nav-item"><a href="contact.aspx" class="nav-link">Contact</a></li>
               
                <% if (Session["user"] == null) { %>
                     <li class="nav-item"><a href="login.aspx" class="nav-link">Login</a></li>
                    <%} %>
                 <%   else
                                                       {%>
                    <li class="nav-item"><a href="login.aspx" class="nav-link">Logout</a></li>
                <%}%>
               
	        </ul>
	      </div>
	    </div>
	  </nav>
    <!-- END nav -->
    
    <section class="hero-wrap hero-wrap-2 ftco-degree-bg js-fullheight" style="background-image: url('images/bg_1.jpg');" data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-center justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
          	<p class="breadcrumbs"><span class="mr-2"><a href="home.aspx">Home <i class="ion-ios-arrow-forward"></i></a></span> <span>Contact <i class="ion-ios-arrow-forward"></i></span></p>
            <h1 class="mb-3 bread">Add Property</h1>
          </div>
        </div>
      </div>
    </section>

		<section class="ftco-section contact-section">
      <div class="container">
     
        <div class="row block-9 justify-content-center mb-5">
          <div class="col-md-8 mb-md-5">
          	<h2 class="text-center">Predict your house value</h2>
            <form action="#" class="bg-light p-5 contact-form">
              <div class="form-group">
                <input type="text" class="form-control" name="t1" placeholder="Enter LotArea">
              </div>
              <div class="form-group">
               <select name="t2" class="form-control">
                   <option>Pave</option>
                   <option>Gurl</option>
               </select>
              </div>
              <div class="form-group">
                <select name="t3" class="form-control">
                   <option>NoSeWa</option>
                   <option>AllPub</option>
               </select>
              </div>
              <div class="form-group">
               <select name="t4" class="form-control">
                   <option>CollgCr</option>
                   <option>Veenker</option>
               </select>
              </div>
               <div class="form-group">
               <select name="t5" class="form-control">
                   <option>2Story</option>
                   <option>1Story</option>
               </select>
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t6" placeholder="Enter OverallQual">
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t7" placeholder="Enter OverallCond">
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t8" placeholder="Enter YearBuilt">
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t9" placeholder="Enter totalbsmtsf">
              </div>
                <div class="form-group">
                <select name="t10" class="form-control">
                    <option>True</option>
                    <option>False</option>
                </select>
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t11" placeholder="Enter 1stFlrsf">
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t12" placeholder="Enter 2ndflrSF">
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t13" placeholder="Enter GrLivArea">
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t14" placeholder="Enter FullBAth">
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t15" placeholder="Enter BedrromAbvGr">
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t16" placeholder="Enter KitchenAbvGr">
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t17" placeholder="Enter SalePrice">
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t18" placeholder="Enter TotalRommAbvGr">
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t19" placeholder="Enter Contact no">
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t20" placeholder="Enter state">
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t21" placeholder="Enter city">
              </div>
                 <div class="form-group">
                <input type="text" class="form-control" name="t23" placeholder="Enter House name">
              </div>
                 <div class="form-group">
                <input type="text" class="form-control" name="t24" placeholder="Enter Bathtub">
              </div>
                 <div class="form-group">
                   <select name="t22" class="form-control">
                    <option>yes</option>
                    <option>no</option>
                </select>
              </div>
                <div class="form-group">
                    Main House Image<asp:FileUpload id="img1" runat="server" />
                </div>
                <div class="form-group">
                   Bedroom Image: <asp:FileUpload id="img2" runat="server" />
                </div>
                <div class="form-group">
                   Kitchen Image <asp:FileUpload id="img3" runat="server" />
                </div>
                <div class="form-group">
                  other image  <asp:FileUpload id="img4" runat="server" />
                </div>
                
              <div class="form-group">
                <input type="submit" value="Predict Price" id="click" runat="server" class="btn btn-primary py-3 px-5">
              </div>
            </form>
          
          </div>
        </div>
    
      </div>
    </section>
 <footer class="ftco-footer ftco-section">
      <div class="container">
        <div class="row mb-5">
          <div class="col-md">
            <div class="ftco-footer-widget mb-4">
              <h2 class="ftco-heading-2">Housevia</h2>
              <p>Far far away, behind the word mountains, far from the countries.</p>
              <ul class="ftco-footer-social list-unstyled mt-5">
                <li class="ftco-animate"><a href="#"><span class="icon-twitter"></span></a></li>
                <li class="ftco-animate"><a href="#"><span class="icon-facebook"></span></a></li>
                <li class="ftco-animate"><a href="#"><span class="icon-instagram"></span></a></li>
              </ul>
            </div>
          </div>
          
         
          
          <div class="col-md">
            <div class="ftco-footer-widget mb-4">
            	<h2 class="ftco-heading-2">Have a Questions?</h2>
            	<div class="block-23 mb-3">
	              <ul>
	                <li><span class="icon icon-map-marker"></span><span class="text">103, sukun bunglows,Nadiad</span></li>
	                <li><a href="#"><span class="icon icon-phone"></span><span class="text">9913558589</span></a></li>
	                <li><a href="#"><span class="icon icon-envelope pr-4"></span><span class="text">housiva@gmail.com</span></a></li>
	              </ul>
	            </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-12 text-center">
	
            <p><!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
  Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved  by <a href="#" >Housevia</a>
  <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. --></p>
          </div>
        </div>
      </div>
    </footer>
    
  

  <!-- loader -->
  <div id="ftco-loader" class="show fullscreen"><svg class="circular" width="48px" height="48px"><circle class="path-bg" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke="#eeeeee"/><circle class="path" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke-miterlimit="10" stroke="#F96D00"/></svg></div>


  <script src="js/jquery.min.js"></script>
  <script src="js/jquery-migrate-3.0.1.min.js"></script>
  <script src="js/popper.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/jquery.easing.1.3.js"></script>
  <script src="js/jquery.waypoints.min.js"></script>
  <script src="js/jquery.stellar.min.js"></script>
  <script src="js/owl.carousel.min.js"></script>
  <script src="js/jquery.magnific-popup.min.js"></script>
  <script src="js/aos.js"></script>
  <script src="js/jquery.animateNumber.min.js"></script>
  <script src="js/bootstrap-datepicker.js"></script>
  <script src="js/jquery.timepicker.min.js"></script>
  <script src="js/scrollax.min.js"></script>
  <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBVWaKrjvy3MaE7SQ74_uJiULgl1JY0H2s&sensor=false"></script>
  <script src="js/google-map.js"></script>
  <script src="js/main.js"></script>
    
  
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>

    
</body>
</html>
