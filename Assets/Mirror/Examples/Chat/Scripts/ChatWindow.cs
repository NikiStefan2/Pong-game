using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.Chat
{
    public class ChatWindow : MonoBehaviour
    {
        static readonly ILogger logger = LogFactory.GetLogger(typeof(ChatWindow));

        public InputField chatMessage;
        public Text chatHistory;
        public Scrollbar scrollbar;

        public Dropdown dropdown;

        public Color coilor1 = Color.red;
        public Color coilor2 = Color.black;//coilo2

        //public string colorTest = "red";

        public string ChoosenColor;
        public string ChoosenColorByHost;

        

        void Start()
        {
            //modifyColors = dropdown.GetComponent<modifyColors>();

            //ChoosenColor = ChatNetworkManager.choosenColor;


        }

        public void Awake()
        {
            Player.OnMessage += OnPlayerMessage;
        }

        void OnPlayerMessage(Player player, string message)
        {
            string prettyMessage = player.isLocalPlayer ?
                $"<color={ChoosenColor}>{player.playerName}: </color> {message}" :
                $"<color={ChoosenColorByHost}>{player.playerName}: </color> {message}";
            AppendMessage(prettyMessage);

            logger.Log(message);
        }

        public void OnSend()
        {
            if (chatMessage.text.Trim() == "")
                return;

            // get our player
            Player player = NetworkClient.connection.identity.GetComponent<Player>();

            // send a message
            player.CmdSend(chatMessage.text.Trim());

            chatMessage.text = "";
        }

        internal void AppendMessage(string message)
        {
            StartCoroutine(AppendAndScroll(message));
        }

        IEnumerator AppendAndScroll(string message)
        {
            chatHistory.text += message + "\n" + "\n";

            // it takes 2 frames for the UI to update ?!?!
            yield return null;
            yield return null;

            // slam the scrollbar down
            scrollbar.value = 0;
        }
    }
}
