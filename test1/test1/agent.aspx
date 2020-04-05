<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agent.aspx.cs" Inherits="test1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

     <title>Uptown - Free Bootstrap 4 Template by Colorlib</title>
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
	      <a class="navbar-brand" href="index.html">Uptown</a>
	      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#ftco-nav" aria-controls="ftco-nav" aria-expanded="false" aria-label="Toggle navigation">
	        <span class="oi oi-menu"></span> Menu
	      </button>

	      <div class="collapse navbar-collapse" id="ftco-nav">
	        <ul class="navbar-nav ml-auto">
	          <li class="nav-item active"><a href="home.aspx" class="nav-link">Home</a></li>
	          <li class="nav-item"><a href="about.aspx" class="nav-link">About</a></li>
	          <li class="nav-item"><a href="agent.aspx" class="nav-link">Agent</a></li>
	          <li class="nav-item"><a href="services.aspx" class="nav-link">Services</a></li>
	          <li class="nav-item"><a href="properties.aspx" class="nav-link">Properties</a></li>
	          <li class="nav-item"><a href="blog.aspx" class="nav-link">Blog</a></li>
	          <li class="nav-item"><a href="contact.aspx" class="nav-link">Contact</a></li>
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
          	<p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-forward"></i></a></span> <span>Contact <i class="ion-ios-arrow-forward"></i></span></p>
            <h1 class="mb-3 bread">Agent</h1>
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
                <input type="text" class="form-control" name="t19" placeholder="Enter Address"/>
              </div>
              <div class="form-group">
                <input type="text" class="form-control" name="t20" placeholder="Enter Pincode"//>
              </div>
              <div class="form-group">
                <input type="text" class="form-control" name="t21" placeholder="Enter State"/>
              </div>
              <div class="form-group">
                <input type="text" class="form-control" name="t22" placeholder="Enter city"/>
              </div>

              <div class="form-group">
                <input type="text" class="form-control" name="t1" placeholder="Enter Total LotArea"/>
              </div>
              <div class="form-group">
               <select name="t2" class="form-control">
                   <option disabled="disabled" selected="selected"> street type</option>
                   <option value="Pave">Paved Road</option>
                   <option value="Grvl">Unpaved Road</option>
               </select>
              </div>
              <div class="form-group">
                <select name="t3" class="form-control">
                    <option disabled="disabled" selected="selected">Utilities</option>
                    <option>NoSeWa</option>
                   <option>AllPub</option>
               </select>
              </div>
              <div class="form-group">
               <select name="t4" class="form-control">
                   <option disabled="disabled" selected="selected">Neighbourhood</option>
                   <option value="CollgCr">CollgCr</option>
                   <option value="Veenker">Veenker</option>
                   <option value="Crawfor">Crawfor</option>
                   <option value="NoRidge">NoRidge</option>
                   <option value="Mitchel">Mitchel</option>
                   <option value="Somerst">Somerst</option>
                   <option value="NWAmes">NWAmes</option>
                   <option value="OldTown">OldTown</option>
                   <option value="BrkSide">BrkSide</option>
                   <option value="Sawyer">Sawyer</option>
                   <option value="NridgHt">NridgHt</option>
                   <option value="IDOTRR">IDOTRR</option>
                   <option value="Edwards">Edwards</option>
                   <option value="Gilbert">Gilbert</option>

               </select>
              </div>
               <div class="form-group">
               <select name="t5" class="form-control">
                   <option disabled="disabled" selected="selected">HouseStyle</option>
                   <option>1Story</option>
                   <option>2Story</option>
               </select>
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t6" placeholder="Enter OverallQuality(1-10)"/>
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t7" placeholder="Enter OverallCondition(1-10)"/>
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t8" placeholder="Enter YearBuilt"/>
              </div>
               <div class="form-group">
                <input type="text" class="form-control" name="t9" placeholder="Enter Total square feet of basement area"/>
              </div>
                <div class="form-group">
                <select name="t10" class="form-control">
                    <option disabled="disabled" selected="selected">Is there Central AC?</option>
                    <option value="True">Yes</option>
                    <option value="False">No</option>
                </select>
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t11" placeholder="Enter First Floor square feet"/>
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t12" placeholder="Enter Second floor square feet"/>
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t13" placeholder="Enter ground living area square feet"/>
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t14" placeholder="Enter Number of bathrooms"/>
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t15" placeholder="Enter Number of bedrooms"/>
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t16" placeholder="Enter Number of kitchens"/>
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t17" placeholder="Enter SalePrice"/>
              </div>
                <div class="form-group">
                <input type="text" class="form-control" name="t18" placeholder="Enter Total Rooms"/>
              </div>
              <div class="form-group">
                <input type="text" class="form-control" name="t24" placeholder="Enter ContactNo"/>
              </div>
                <div class="form-group">
                  <input type="file" class="form-control" name="t23" />
              </div>  

              <div class="form-group">
                <input type="submit" value="Predict Price" id="click" runat="server" class="btn btn-primary py-3 px-5"/>
              </div>

                <asp:Label ID="Label2" runat="server" Text="Labe2"></asp:Label>
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
              <h2 class="ftco-heading-2">Uptown</h2>
              <p>Far far away, behind the word mountains, far from the countries.</p>
              <ul class="ftco-footer-social list-unstyled mt-5">
                <li class="ftco-animate"><a href="#"><span class="icon-twitter"></span></a></li>
                <li class="ftco-animate"><a href="#"><span class="icon-facebook"></span></a></li>
                <li class="ftco-animate"><a href="#"><span class="icon-instagram"></span></a></li>
              </ul>
            </div>
          </div>
          <div class="col-md">
            <div class="ftco-footer-widget mb-4 ml-md-4">
              <h2 class="ftco-heading-2">Community</h2>
              <ul class="list-unstyled">
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>Search Properties</a></li>
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>For Agents</a></li>
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>Reviews</a></li>
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>FAQs</a></li>
              </ul>
            </div>
          </div>
          <div class="col-md">
            <div class="ftco-footer-widget mb-4 ml-md-4">
              <h2 class="ftco-heading-2">About Us</h2>
              <ul class="list-unstyled">
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>Our Story</a></li>
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>Meet the team</a></li>
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>Careers</a></li>
              </ul>
            </div>
          </div>
          <div class="col-md">
             <div class="ftco-footer-widget mb-4">
              <h2 class="ftco-heading-2">Company</h2>
              <ul class="list-unstyled">
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>About Us</a></li>
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>Press</a></li>
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>Contact</a></li>
                <li><a href="#"><span class="icon-long-arrow-right mr-2"></span>Careers</a></li>
              </ul>
            </div>
          </div>
          <div class="col-md">
            <div class="ftco-footer-widget mb-4">
            	<h2 class="ftco-heading-2">Have a Questions?</h2>
            	<div class="block-23 mb-3">
	              <ul>
	                <li><span class="icon icon-map-marker"></span><span class="text">203 Fake St. Mountain View, San Francisco, California, USA</span></li>
	                <li><a href="#"><span class="icon icon-phone"></span><span class="text">+2 392 3929 210</span></a></li>
	                <li><a href="#"><span class="icon icon-envelope pr-4"></span><span class="text">info@yourdomain.com</span></a></li>
	              </ul>
	            </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-12 text-center">
	
            <p><!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
  Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class="icon-heart color-danger" aria-hidden="true"></i> by <a href="https://colorlib.com" target="_blank">Colorlib</a>
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
