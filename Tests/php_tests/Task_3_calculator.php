<html>
<head><title>Sticky Calculator</title></head>
<body>

<?php
    $num1 = $_GET['num1'];
    $num2 = $_GET['num2'];
?>

<form action="<?php echo $_SERVER['PHP_SELF'] ?>" method="GET">

Num 1: <input type="text" name="num1" value="<?php echo $num1 ?>" />
<br />

Num 2: <input type="text" name="num2" value="<?php echo $num2 ?>" />
<br /> <br/>

<input type="submit" name="ans" value="+" />
<input type="submit" name="ans" value="-" />
<input type="submit" name="ans" value="*" />
<input type="submit" name="ans" value="/" />
</form>

<?php
    if(! is_null($num1) && ! is_null($num2)) {
        $op = $_GET['ans'];
        if($op == "+") {
            $result = $num1 + $num2;
            printf("%d + %d = %d", $num1, $num2, $result) ;
        } else if($op == "-") {
            $result = $num1 - $num2;
            printf("%d - %d = %d", $num1, $num2, $result) ;
        } else if($op == "*") {
            $result = $num1 * $num2;
            printf("%d * %d = %d", $num1, $num2, $result) ;
        } else if($op == "/") {
            if($num2 != 0){
                $result = $num1 / $num2;
                printf("%d / %d = %f", $num1, $num2, $result) ;
            } else {   
                echo "Div by zero error!";
            }
        }
    }
?>

</body>
</html>

