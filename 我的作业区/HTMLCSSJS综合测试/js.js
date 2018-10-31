window.onload = function () {
    var slider = document.getElementById('slider');
    var ul = document.getElementById('ad_ul');
    var ol = document.getElementById('ad_ol');
    var ollis = ol.children;
    var leader = 0;
    var target = 0;

    for (var i = 0; i < ollis.length; i++) {
        ollis[i].index = i;
        ollis[i].onmouseover = function () {
            for (var j = 0; j < ollis.length; j++) {
                ollis[j].className = '';
            }

            this.className = 'current';
            target = -this.index * 500;
        }
    }
    setInterval(function () {
        leader = leader + (target - leader) / 10;
        ul.style.left = leader + 'px';
    }, 20);
}

    //鼠标悬停事件
    scroll.onmouseover = function() {
        clearInterval(timer);
    }
    scroll.onmouseout = function() {
        timer = setInterval(autoPlay, 10);
    }

 //定义定时器，按周期tab栏的切换
 function autuCheck() {
    //每间隔对应周期 ，标签索引值自增
    ++current_index;
    //当索引值自增到上限 重置为0
    if (current_index == scroll.length)
        current_index = 0;
    //切换标签后修改current标签的样式
    for (var i = 0; i < scroll.length; i++) {
        if (i == current_index) {
            scroll[i].style.backgroundColor = '#fff';
            scroll[i].style.borderBottom = '1px solid #fff';
        } else {
            scroll[i].style.backgroundColor = '';
            scroll[i].style.borderBottom = '';
        }
    }
    //切换显示的内容
    //获取所有的tab-body-ul
    var ad_ols = document.getElementById('ad_ol').getElementsByTagName('ol');
    //遍历所有的tab-body-ul
    for (var i = 0; i < ad_ols.length; i++) {
        //将所有的元素隐藏 去掉current类名
        ad_ols[i].className = ad_ols[i].className.replace(' current', '');
        scroll[i].className = scroll[i].className.replace(' current', '');
        //将当前索引对应的元素设为显示
        if (scroll[i] == scroll[current_index]) {
            this.className += ' current';
            ad_ols[i].className += ' current';
        }
    }
}
