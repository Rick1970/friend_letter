using Nancy;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/hello"] = _ => "Hello friend!";
      Get["/goodbye"] = _ => "Goodbye friend-o!";
      Get["/"] = _ =>
        "<!DOCTYPE html>" +
        "<html>" +
        "<head>" +
          "<title>Hello Friend!</title>" +
          "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
          "<link rel='stylesheet' href='Content/css/Styles.css'>" +
        "</head>" +
        "<body class='container'>" +
          "<h1>Hello From Afar</h1>" +
          "<p>Dear Friend,</p>" +
          "<p>How are you? I hope that you are having a nice weekend. I'm learning programming while in Iceland! </p>" +
          "<p>Friend, you would not believe how cold it is here. I should have gone to Hawaii instead.</p>" +
          "<p>But I like programming a lot, so I've got that going for me. </p>" +
          "<p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>" +
          "<p>Cheers,</p>" +
          "<p>Travel Enthusiast Jane</p>" +
          "<p><a href='/favorite_photos'>P.S. Check out these super-secret puppies!!!!</a></p>"  +
        "</body>" +
        "</html>";
      Get["/favorite_photos"] = _ =>
        "<!DOCTYPE html>" +
        "<html>" +
          "<head>" +
            "<title>Hello Friend!</title>" +
            "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
          "</head>" +
          "<body>" +
            "<h1>Favorite Puppy Photos</h1>" +
            "<ul>" +
              "<li><img src='Content/img/photo1.jpg'/></li>" +
              "<li><img src='Content/img/photo2.jpg'/></li>" +
              "<li><img src='Content/img/photo3.jpg'/></li>" +
            "</ul>" +
          "</body>" +
        "</html>";
    }
  }
}
