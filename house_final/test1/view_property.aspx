<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_property.aspx.cs" Inherits="test1.view_property" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Houseiva|ViewProperty</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
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
        <div>
            
    
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
    
    <div class="hero-wrap ftco-degree-bg" style="background-image: url('images/bg_1.jpg');" data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text justify-content-center align-items-center">
          <div class="col-lg-8 col-md-6 ftco-animate d-flex align-items-end">
          	<div class="text text-center">
	            <h1 class="mb-4">The Simplest <br>Way to Find Property</h1>
	            <p style="font-size: 18px;">A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts</p>
	            <form action="#" class="search-location mt-md-5">
		        		<div class="row justify-content-center">
		        			<div class="col-lg-10 align-items-end">
		        				<div class="form-group">
		          				<div class="form-field">
				                
				              </div>
			              </div>
		        			</div>
		        		</div>
		        	</form>
            </div>
          </div>
        </div>
      </div>
      <div class="mouse">
				<a href="#" class="mouse-icon">
					<div class="mouse-wheel"><span class="ion-ios-arrow-round-down"></span></div>
				</a>
			</div>
    </div>
   <section class="ftco-section goto-here">
    	<div class="container">
    		<div class="row justify-content-center">
          <div class="col-md-12 heading-section text-center ftco-animate mb-5">
          
            <h2 class="mb-2">Your Property</h2>
          </div>
        </div>
            <h1>
 

            </h1>
        <div class="row">
             <% foreach (var i in h) { %>
   
        	<div class="col-md-4">
        		<div class="property-wrap ftco-animate">
        			  <img src='<%=i.Image1 %>' class="img" />
        			<div class="text">
                       
        				<p class="price"><i class="fa fa-money"></i>&nbsp;&nbsp;<%= i.Price %></p>
        				<ul class="property_list">
        					<li><span class="flaticon-bed"></span><%= i.NoOfBedroom %></li>
        					<li><span class="flaticon-bathtub"></span><%= i.Bath %></li>
        					<li><span class="flaticon-floor-plan"></span><%= i.SquareFt %></li>
        				</ul>
        				<h3><a href="#"><%= i.Name %></a></h3>
        				<span class="location" id="p1"><%= i.State %></span>
                       House No <span id="span1"  ><%= i.Id %></span>
        				<a href="#" class="d-flex align-items-center justify-content-center btn-custom">
                           
                          <input type="text" name="idval"  value="<%=i.Id %>" />
                         
                         
        				</a>
        			</div>
        		</div>
        	</div>
            <% } %>
          </div>
            <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Delete Property</button>

  <!-- Modal -->
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Select House Name</h4>
        </div>
        <div class="modal-body">
          <p>  <select name="hname">
                  <% foreach (var i in h) { %>
              <option><%= i.Name %></option>
                <% } %>
               </select>
          
          </p>
            <input type="submit" runat="server" id="hnameid"  value="Delete"/>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        </div>
      </div>
    </div>
  </div>

        </div>
    	</div>
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
    
 
        </div>
    </form>
    </section>
