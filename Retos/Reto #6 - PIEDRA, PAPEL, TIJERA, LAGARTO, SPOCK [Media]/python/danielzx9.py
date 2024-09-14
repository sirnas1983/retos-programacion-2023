# # Reto #6: Piedra, Papel, Tijera, Lagarto, Spock
# #### Dificultad: Media | Publicación: 06/02/23 | Corrección: 13/02/23

# ## Enunciado

# ```
# /*
#  * Crea un programa que calcule quien gana más partidas al piedra,
#  * papel, tijera, lagarto, spock.
#  * - El resultado puede ser: "Player 1", "Player 2", "Tie" (empate)
#  * - La función recibe un listado que contiene pares, representando cada jugada.
#  * - El par puede contener combinaciones de "🗿" (piedra), "📄" (papel),
#  *   "✂️" (tijera), "🦎" (lagarto) o "🖖" (spock).
#  * - Ejemplo. Entrada: [("🗿","✂️"), ("✂️","🗿"), ("📄","✂️")]. Resultado: "Player 2".
#  * - Debes buscar información sobre cómo se juega con estas 5 posibilidades.
#  */
# ```
# #### Tienes toda la información extendida sobre los retos de programación semanales en **[retosdeprogramacion.com/semanales2023](https://retosdeprogramacion.com/semanales2023)**.

# Sigue las **[instrucciones](../../README.md)**, consulta las correcciones y aporta la tuya propia utilizando el lenguaje de programación que quieras.

# > Recuerda que cada semana se publica un nuevo ejercicio y se corrige el de la semana anterior en directo desde **[Twitch](https://twitch.tv/mouredev)**. Tienes el horario en la sección "eventos" del servidor de **[Discord](https://discord.gg/mouredev)**.

def ganador(jugadas):
    reglas = {
        ("🗿", "🗿"): "Tie",
        ("🗿", "✂️"): "Player 1",
        ("🗿", "📄"): "Player 2",
        ("🗿", "🦎"): "Player 1",
        ("🗿", "🖖"): "Player 2",
        ("✂️", "🗿"): "Player 2",
        ("✂️", "✂️"): "Tie",
        ("✂️", "📄"): "Player 1",
        ("✂️", "🦎"): "Player 2",
        ("✂️", "🖖"): "Player 1",
        ("📄", "🗿"): "Player 1",
        ("📄", "✂️"): "Player 2",
        ("📄", "📄"): "Tie",
        ("📄", "🦎"): "Player 1",
        ("📄", "🖖"): "Player 2",
        ("🦎", "🗿"): "Player 2",
        ("🦎", "✂️"): "Player 1",
        ("🦎", "📄"): "Player 2",
        ("🦎", "🦎"): "Tie",
        ("🦎", "🖖"): "Player 1",
        ("🖖", "🗿"): "Player 1",
        ("🖖", "✂️"): "Player 2",
        ("🖖", "📄"): "Player 1",
        ("🖖", "🦎"): "Player 2",
        ("🖖", "🖖"): "Tie"
    }
    
    contador = {"Player 1": 0, "Player 2": 0, "Tie": 0}
    
    for jugada in jugadas:
        resultado = reglas[jugada]
        contador[resultado] += 1
    
    if contador["Player 1"] > contador["Player 2"]:
        return "Player 1"
    elif contador["Player 2"] > contador["Player 1"]:
        return "Player 2"
    else:
        return "Tie"

# Ejemplo de uso
jugadas = [("🗿","✂️"), ("✂️","🗿"), ("📄","✂️")]
resultado = ganador(jugadas)
print("El ganador es: ", resultado)
