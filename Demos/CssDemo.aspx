<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <style>
        h1
        {
            font-size: 20px;
            color: green;
        }

        p
        {
            color : #0000FF;
            font-style : italic;
        }

        .RightAligned
        {
            text-align: right;
        }
        #IntroText
        {
            font-style:italic;
            text-align:center;
        }

        .MyDiv
        {
            width: 200px;
            padding: 10px;
            border: 2px solid Black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <h1>Welcomne to the Nucor Yamato Stell Company</h1>
        <p>CSS make it supert easy to style your page</p>
        <p class ="RightAligned">
            With very little code, you can quickly change the look of page
        </p>
        <p id ="IntroText">
            Leo is the best
        </p>
        <div class="MyDiv">
            Element
        </div>
    </div>
    </form>
</body>
</html>
