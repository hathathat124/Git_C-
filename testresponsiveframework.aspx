<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testresponsiveframework.aspx.cs" Inherits="testresponsiveframework" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <%--<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>--%>
    <link href="vendor/bootstrap2/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="vendor/bootstrap2/css/bootstrap-responsive.min.css" rel="stylesheet"/>
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.11.3.min.js"></script>
    

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/css/bootstrap-datepicker3.css"/>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/js/bootstrap-datepicker.min.js"></script>

    <title></title>
            <style>
                * {
    box-sizing: border-box;
}

input[type=text], select, textarea{
    width: 100%;
    padding: 12px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
    resize: vertical;
}

label {
    padding: 12px 12px 12px 0;
    display: inline-block;
}

input[type=submit] {
    background-color: #4CAF50;
    color: white;
    padding: 12px 20px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
    float: right;
}

input[type=submit]:hover {
    background-color: #45a049;
}

.container {
    border-radius: 5px;
    background-color: #f2f2f2;
    padding: 20px;
}

.col-25 {
    float: left;
    width: 25%;
    margin-top: 6px;
}

.col-75 {
    float: left;
    width: 75%;
    margin-top: 6px;
}

/* Clear floats after the columns */
.row:after {
    content: "";
    display: table;
    clear: both;
}

/* Responsive layout - when the screen is less than 600px wide, make the two columns stack on top of each other instead of next to each other */
@media (max-width: 600px) {
    .col-25, .col-75, input[type=submit] {
        width: 100%;
        margin-top: 0;
    }
}

    </style>
</head>
<body style="background:url(images/latar.png)">
    <form id="form1" runat="server">
         <div class="container">
         <div class="row">
  <div class="col-sm-4">.col-sm-4</div>
  <div class="col-sm-4">.col-sm-4</div>
  <div class="col-sm-4">.col-sm-4</div>
</div>

             </div>
          <div class= "form-group" > 
              <label for= "exampleInputEmail1" > Email address </label> 
                <input type= "email" class= "form-control" id= "exampleInputEmail1" placeholder= "Email" > 

          </div> 
        <div class= "form-group" > 
            <label for= "exampleInputPassword1" > Password </label> 
            <input type= "password" class= "form-control" id= "exampleInputPassword1" placeholder= "Password" /> 

        </div> 
        <div class= "form-group" > 
            <label for= "exampleInputFile" > File input </label> 
            <input type= "file" id= "exampleInputFile" /> 
            <p class= "help-block" > Example block-level help text here. </p> 
        </div> 
        <div class= "checkbox" > 
            <label> <input type= "checkbox" > Check me out </label> 

        </div> 
        <button type= "submit" class= "btn btn-default" > Submit </button> 


<%--<div class="w3-container w3-green">
  <h1>W3Schools Demo</h1> 
  <p>Resize this responsive page!</p> 
</div>

<div class="w3-row-padding">
  <div class="w3-third">
    <h2>London</h2>
    <p>London is the capital city of England.</p>
    <p>It is the most populous city in the United Kingdom,
    with a metropolitan area of over 13 million inhabitants.</p>
  </div>

  <div class="w3-third">
    <h2>Paris</h2>
    <p>Paris is the capital of France.</p> 
    <p>The Paris area is one of the largest population centers in Europe,
    with more than 12 million inhabitants.</p>
  </div>

  <div class="w3-third">
    <h2>Tokyo</h2>
    <p>Tokyo is the capital of Japan.</p>
    <p>It is the center of the Greater Tokyo Area,
    and the most populous metropolitan area in the world.</p>
  </div>
</div>--%>
        <div class="row-fluid">
            <nav id="mainNav" class="navbar navbar-default navbar-fixed-top">
                <img width="300" style="max-width:500px;height:80px;" src="/images/head_logo_sci.png" />
            </nav>
        </div>
    
        <div class="w3-container w3-green" style="margin-top:100px" >
  <h1>W3Schools Demo</h1> 
  <p>Resize this responsive page!</p> 
</div>

<div class="w3-row-padding">
  <div class="w3-third">
    <h2>London</h2>
    <p>London is the capital city of England.</p>
    <p>It is the most populous city in the United Kingdom,
    with a metropolitan area of over 13 million inhabitants.</p>
  </div>

  <div class="w3-third">
    <h2>Paris</h2>
    <p>Paris is the capital of France.</p> 
    <p>The Paris area is one of the largest population centers in Europe,
    with more than 12 million inhabitants.</p>
  </div>

  <div class="w3-third">
    <h2>Tokyo</h2>
    <p>Tokyo is the capital of Japan.</p>
    <p>It is the center of the Greater Tokyo Area,
    and the most populous metropolitan area in the world.</p>
  </div>
</div>
        <h2>Responsive Form</h2>
<p>Resize the browser window to see the effect. When the screen is less than 600px wide, make the two columns stack on top of each other instead of next to each other.</p>

<div class="container">
  <form action="/action_page.php">
    <div class="row">
      <div class="col-25">
        <label for="fname">First Name</label>
      </div>
      <div class="col-75">
        <input type="text" id="fname" name="firstname" placeholder="Your name..">
      </div>
    </div>
    <div class="row">
      <div class="col-25">
        <label for="lname">Last Name</label>
      </div>
      <div class="col-75">
        <input type="text" id="lname" name="lastname" placeholder="Your last name..">
      </div>
    </div>
    <div class="row">
      <div class="col-25">
        <label for="country">Country</label>
      </div>
      <div class="col-75">
        <select id="country" name="country">
          <option value="australia">Australia</option>
          <option value="canada">Canada</option>
          <option value="usa">USA</option>
        </select>
      </div>
    </div>
    <div class="row">
      <div class="col-25">
        <label for="subject">Subject</label>
      </div>
      <div class="col-75">
        <textarea id="subject" name="subject" placeholder="Write something.." style="height:200px"></textarea>
      </div>
    </div>
    <div class="row">
      <input type="submit" value="Submit">
    </div>
  </form>
</div>

<div class="row">
    <div class="span1">Column 1</div>
    <div class="span1">Column 2</div>
    <div class="span1">Column 3</div>
    <div class="span1">Column 4</div>
    <div class="span1">Column 5</div>
    <div class="span1">Column 6</div>
    <div class="span1">Column 7</div>
    <div class="span1">Column 8</div>
    <div class="span1">Column 9</div>
    <div class="span1">Column 10</div>
    <div class="span1">Column 11</div>
    <div class="span1">Column 12</div>

</div>
<div class="row-fluid">
    <div class="span2">Mains</div>
    <div class="span8">Sidebars
    <div class="row-fluid">
        <div class="span2">Mains</div>
        <div class="span2">Mains</div>
        <div class="span2">Mains</div>
        <div class="span2">Mains</div>

    </div>
    </div>
    
</div>


        <div class="row">
    <div class="span3">Secondary</div>
    <div class="span6">Primary</div>
    <div class="span3">Sidebar</div>
</div>
        <div class="row">
    <div class="span2">Logo</div>
    <div class="span4 offset5">Search</div>
</div>
        <div class="row">
    <div class="span8">
        Main
        <div class="row">
            <div class="span2">Menu</div>
            <div class="span4">Content</div>
        </div>
    </div>
    <div class="span4">Sidebar</div>
</div>
    
 ========================================================================================================================
        <div class="container-fluid">
	    <div class="row-fluid" style="">
    <div class="span1">Column 1</div>
    <div class="span1">Column 2</div>
    <div class="span1">Column 3</div>
    <div class="span1">Column 4</div>
    <div class="span1">Column 5</div>
    <div class="span1">Column 6</div>
    <div class="span1">Column 7</div>
    <div class="span1">Column 8</div>
    <div class="span1">Column 9</div>
    <div class="span1">Column 10</div>
    <div class="span1">Column 11</div>
    <div class="span1">Column 12</div>

</div> 
	
<div class="row-fluid">
    <div class="span8">Main</div>
    <div class="span4">Sidebar</div>
</div>
            <div class="row-fluid">
    <div class="span8">
        <div class="row-fluid">
            <div class="span3">Menu</div>
            <div class="span9">Content</div>
        </div>
    </div>
    <div class="span4">Sidebar</div>
</div>
            

        <div class="row-fluid">
    <div class="span3">Secondary</div>
    <div class="span6">Primary</div>
    <div class="span3 visible-desktop">Sidebar</div>
</div>
        <div class="row-fluid">
            <div class="span9 offset3">
        <table class="table table-striped">
    <thead>
        <tr>
            <th>#</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Username</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>1</td>
            <td>Mark</td>
            <td>Otto</td>
            <td>@mdo</td>
        </tr>
        <tr>
            <td>2</td>
            <td>Jacob</td>
            <td>Thornton</td>
            <td>@fat</td>
        </tr>
        <tr>
            <td>3</td>
            <td>Larry</td>
            <td>the Bird</td>
            <td>@twitter</td>
        </tr>
    </tbody>
</table>
            </div>
            </div>
    </div>


        
      
    </form>
    <%--<script src="vendor/jquery/jquery.js"></script>--%>
    <script src="vendor/bootstrap2/js/bootstrap.min.js/bootstrap.min.js"></script>
</body>
</html>
