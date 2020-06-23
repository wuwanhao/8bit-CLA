/*
    * 1.提取二进制数的每一位作为a[i]和b[i]
    * 2.c0代表最低位的外来进位，c0=0代表正逻辑，c0=1代表负逻辑
    * 3.参与运算
    * 4.将运算结果输出
    * */

function getInt(k)
{
    if(k){
        return "1";
    }else{
        return "0"
    }
}

function toSign(k)
{
    if(k == 1){
        return "√";
    }else{
        return " "
    }
}

function getValue() {
    let c0 = 0;

    var a_checkBox = document.getElementsByName('a');
    let a7 = getInt(a_checkBox[0].checked);
    let a6 = getInt(a_checkBox[1].checked);
    let a5 = getInt(a_checkBox[2].checked);
    let a4 = getInt(a_checkBox[3].checked);
    let a3 = getInt(a_checkBox[4].checked);
    let a2 = getInt(a_checkBox[5].checked);
    let a1 = getInt(a_checkBox[6].checked);
    let a0 = getInt(a_checkBox[7].checked);

    var b_checkBox = document.getElementsByName('b');
    let b7 = getInt(b_checkBox[0].checked);
    let b6 = getInt(b_checkBox[1].checked);
    let b5 = getInt(b_checkBox[2].checked);
    let b4 = getInt(b_checkBox[3].checked);
    let b3 = getInt(b_checkBox[4].checked);
    let b2 = getInt(b_checkBox[5].checked);
    let b1 = getInt(b_checkBox[6].checked);
    let b0 = getInt(b_checkBox[7].checked);



    // 传递进位
    let p0 = a0^b0;
    let p1 = a1^b1;
    let p2 = a2^b2;
    let p3 = a3^b3;
    let p4 = a4^b4;
    let p5 = a5^b5;
    let p6 = a6^b6;
    let p7 = a7^b7;

    // 本地进位
    let g0 = a0&b0;
    let g1 = a1&b1;
    let g2 = a2&b2;
    let g3 = a3&b3;
    let g4 = a4&b4;
    let g5 = a5&b5;
    let g6 = a6&b6;
    let g7 = a7&b7;

    let p = document.getElementsByName('p');
    p[0].innerText = p7;
    p[1].innerText = p6;
    p[2].innerText = p5;
    p[3].innerText = p4;
    p[4].innerText = p3;
    p[5].innerText = p2;
    p[6].innerText = p1;
    p[7].innerText = p0;

    let g = document.getElementsByName('g');
    g[0].innerText = g7;
    g[1].innerText = g6;
    g[2].innerText = g5;
    g[3].innerText = g4;
    g[4].innerText = g3;
    g[5].innerText = g2;
    g[6].innerText = g1;
    g[7].innerText = g0;


    // 进位
    let c1 = g0 | p0&c0;
    let c2 = g1 | p1&g0 | p1&p0&c0;
    let c3 = g2 | p2&g1 | p2&p1&g0 | p2&p1&p0&c0;
    let c4 = g3 | p3&g2 | p3&p2&g1 | p3&p2&p1&g0 | p3&p2&p1&p0&c0;
    let c5 = g4 | p4&g3 | p4&p3&g2 | p4&p3&p2&g1 | p4&p3&p2&p1&g0 | p4&p3&p2&p1&p0&c0;
    let c6 = g5 | p5&g4 | p5&p4&g3 | p5&p4&p3&g2 | p5&p4&p3&p2&g1 | p5&p4&p3&p2&p1&g0 | p5&p4&p3&p2&p1&p0&c0;
    let c7 = g6 | p6&g5 | p6&p5&g4 | p6&p5&p4&g3 | p6&p5&p4&p3&g2 | p6&p5&p4&p3&p2&g1 | p6&p5&p4&p3&p2&p1&g0 | p6&p5&p4&p3&p2&p1&p0&c0;
    let c8 = g7 | p7&g6 | p7&p6&g5 | p7&p6&p5&g4 | p7&p6&p5&p4&g3 | p7&p6&p5&p4&p3&g2 | p7&p6&p5&p4&p3&p2&g1 | p7&p6&p5&p4&p3&p2&p1&g0 | p7&p6&p5&p4&p3&p2&p1&p0&c0;
    let c = document.getElementsByName('c');
    c[0].innerText = toSign(c8);
    c[1].innerText = toSign(c7);
    c[2].innerText = toSign(c6);
    c[3].innerText = toSign(c5);
    c[4].innerText = toSign(c4);
    c[5].innerText = toSign(c3);
    c[6].innerText = toSign(c2);
    c[7].innerText = toSign(c1);


    // 8为超前进位逻辑电路
    let s0 = (a0^b0)^c0;
    let s1 = (a1^b1)^((a0&b0) | (a0^b0)&c0);
    let s2 = (a2^b2)^((a1&b1) | (a1^b1)&(a0&b0) | (a1^b1)&(a0&b0)&c0);
    let s3 = (a3^b3)^((a2&b2) | (a2^b2)&(a1&b1) | (a2^b2)&(a1^b1)&(a0&b0) | (a2^b2)&(a1^b1)&(a0&b0)&c0);
    let s4 = (a4^b4)^((a3&b3) | (a3^b3)&(a2&b2) | (a3^b3)&(a2^b2)&(a1&b1) | (a3^b3)&(a2^b2)&(a1^b1)&(a0&b0) | (a3^b3)&(a2^b2)&(a1^b1)&(a0^b0)&c0);
    let s5 = (a5^b5)^((a4&b4) | (a4^b4)&(a3&b3) | (a4^b4)&(a3^b3)&(a2&b2) | (a4^b4)&(a3^b3)&(a2^b2)&(a1&b1) | (a4^b4)&(a3^b3)&(a2^b2)&(a1^b1)&(a0&b0) | (a4^b4)&(a3^b3)&(a2^b2)&(a1^b1)&(a0^b0)&c0);
    let s6 = (a6^b6)^((a5&b5) | (a5^b5)&(a4&b4) | (a5^b5)&(a4^b4)&(a3&b3) | (a5^b5)&(a4^b4)&(a3^b3)&(a2&b2) | (a5^b5)&(a4^b4)&(a3^b3)&(a2^b2)&(a1&b1) | (a5^b5)&(a4^b4)&(a3^b3)&(a2^b2)&(a1^b1)&(a0&b0) | (a5^b5)&(a4^b4)&(a3^b3)&(a2^b2)&(a1^b1)&(a0^b0)&c0);
    let s7 = (a7^b7)^((a6&b6) | (a6^b6)&(a5&b5) | (a6^b6)&(a5^b5)&(a4&b4) | (a6^b6)&(a5^b5)&(a4^b4)&(a3&b3) | (a6^b6)&(a5^b5)&(a4^b4)&(a3^b3)&(a2&b2) | (a6^b6)&(a5^b5)&(a4^b4)&(a3^b3)&(a2^b2)&(a1&b1) | (a6^b6)&(a5^b5)&(a4^b4)&(a3^b3)&(a2^b2)&(a1^b1)&(a0&b0) | (a6^b6)&(a5^b5)&(a4^b4)&(a3^b3)&(a2^b2)&(a1^b1)&(a0^b0)&c0);
    let result = s7.toString() + s6.toString() + s5.toString() + s4.toString() + s3.toString() + s2.toString() + s1.toString() + s0.toString();
    console.log(result)
    document.getElementById('res').value = result
}



