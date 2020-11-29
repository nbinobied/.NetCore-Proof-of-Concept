const app = new Vue({
    el: '#app',
    data() {
        return {
        }
    },
    mounted() {
    },
    methods: {
    }
})
try {
    new QRCode(document.getElementById("qrcode"), "http://jindo.dev.naver.com/collie");

    var c = document.getElementById("log");
    c.innerHTML = "printed";
}
catch (err) {
    var c = document.getElementById("log");
    c.innerHTML = "catch: " + err.messge;
}