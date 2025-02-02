# Proyecto Final 2 - Juego de Combate

Este proyecto es un juego de combate simple desarrollado en C# utilizando Windows Forms. El jugador se enfrenta a un enemigo en un combate por turnos, donde puede elegir entre atacar o defenderse.

## Descripción

El juego permite al jugador enfrentarse a un enemigo en un combate por turnos. El jugador puede elegir entre atacar o defenderse. El daño es calculado aleatoriamente en cada turno. El juego se reinicia cuando cualquiera de los personajes pierde toda su vida.

## Características

- El jugador y el enemigo comienzan con 100 puntos de vida.
- El jugador puede elegir entre dos acciones:
  - **Atacar**: Causa un daño aleatorio entre 10 y 20 puntos al enemigo.
  - **Defender**: Reduce el daño recibido entre 5 y 10 puntos.
- El enemigo ataca al jugador en su turno, causando un daño aleatorio entre 10 y 15 puntos.
- El juego se reinicia automáticamente cuando un personaje es derrotado.

## Requisitos

- **Visual Studio** con soporte para Windows Forms.
- **.NET Framework** (la versión que se esté utilizando en el proyecto).

## Instrucciones de Uso

1. Clona este repositorio a tu máquina local:
   ```bash
   git clone https://github.com/tu-usuario/proyecto-final2.git
