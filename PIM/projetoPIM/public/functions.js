function buildBotoes() {
var botoes = [
    'Aventura', 
    'Cartas', 
    'Casual', 
    'Corrida', 
    'Esportes',
    'Estrategia',
    'Exploração',
    'FPS',
    'IND',
    'Luta',
    'MMO',
    'MOBA',
    'Multiplayer',
    'online',
    'Plataforma',
    'Quebra cabeça',
    'RPG',
    'Simulador',
    'Sobrevivencia',
    'Terror']

var categorias = [
    'aventura', 
    'cartas', 
    'casual', 
    'corrida', 
    'esportes',
    'estrategia',
    'exploracao',
    'fps',
    'ind',
    'luta',
    'mmo',
    'moba',
    'multiplayer',
    'online',
    'plataforma',
    'quebracabeca',
    'rpg',
    'simulador',
    'sobrevivencia',
    'terror']
    
    for (var i = 0; i < botoes.length; i++) {
        console.log(i)
        div_botoes.innerHTML += `<a class="a_categoria" onclick="func1('${categorias[i]}','gratis')">${botoes[i]}</a>`
    }
}
function func1(categoria, preco) {
    setTimeout(function () {
        window.location.href = `./loadingGERAL.html?categoria=${categoria}&preco=${preco}`;
    }, 500);
}