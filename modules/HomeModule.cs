using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["favorite_photos"] = _ => View["favorite_photos.cshtml"];
      Get["/"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient("Eric");
        myLetterVariables.SetSender("John");
        return View["hello.cshtml", myLetterVariables];
  };
    }
  }
}
