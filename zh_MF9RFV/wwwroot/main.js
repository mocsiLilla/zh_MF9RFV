fetch(`jokes/all`)
    .then(response => response.json())
    .then(data => IdListába(data));

var sorszám = 0;
var jokeSk = [];

function IdListába(data) {
    for (var i = 0; i < data.length; i++) {
        szám = data[i].jokeSk;
        jokeSk.push(szám);
    }
    ViccBetöltés(jokeSk[sorszám]);
}

function ViccBetöltés(id) {
    fetch(`jokes/${id}`)
        .then(response => response.json())
        .then(data => Kiíratás(data));
}

function Kiíratás(data) {
    let elem = data.jokeText;
    document.getElementById("kiválasztottVicc").innerText = elem;
}

function KövetkezőVicc() {
    sorszám++;
    ViccBetöltés(jokeSk[sorszám]);
}

window.onload = function (e) {
    document.getElementById("add").onclick = KövetkezőVicc;
}