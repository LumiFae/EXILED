using Exiled.Events.EventArgs.Snake;

namespace Exiled.Events.Handlers
{
    using Exiled.Events.Features;

    public class Snake
    {
        /// <summary>
        /// Invoked when gaining score in Snake.
        /// </summary>
        public static Event<GainedScoreEventArgs> GainedScore = new();

        /// <summary>
        /// Invoked when a player loses in Snake.
        /// </summary>
        public static Event<GameOverEventArgs> GameOver = new();

        /// <summary>
        /// Invoked when a player starts a new game.
        /// </summary>
        public static Event<NewGameEventArgs> NewGame = new();

        /// <summary>
        /// Called when a player gains score in Snake.
        /// </summary>
        /// <param name="ev">The <see cref="GainedScoreEventArgs"/> instance.</param>
        public static void OnGainedScore(GainedScoreEventArgs ev)
        {
            GainedScore.InvokeSafely(ev);
        }

        /// <summary>
        /// Called when a player loses in Snake.
        /// </summary>
        /// <param name="ev">The <see cref="GameOverEventArgs"/> instance.</param>
        public static void OnGameOver(GameOverEventArgs ev)
        {
            GameOver.InvokeSafely(ev);
        }

        /// <summary>
        /// Called when a player starts a new game in Snake.
        /// </summary>
        /// <param name="ev">The <see cref="NewGameEventArgs"/> instance.</param>
        public static void OnNewGame(NewGameEventArgs ev)
        {
            NewGame.InvokeSafely(ev);
        }
    }
}