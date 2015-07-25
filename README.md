Gmail-Feed
==========

Gmail-Feed retrieves the the unread messages from inbox and display the feed in the grid form.

How To Use :
------------

- Gmailfeed2/default.aspx.cs

Edit the default.aspx.cs file under the comment 

```javascript
    /*Gmail Username and Password Section*/
    
    string username = "/*______Replace With Your Gmail Username__________*/";
    string password = "/*______Replace with your Gmail Password__________*/";
    string url = (@"https://gmail.google.com/gmail/feed/atom");
    
Example:
--------
    
    
    /*Gmail Username and Password Section*/
    
    string username = "subodhgithub"; // Gmail Username
    string password = "Github123"; // Gmail Password
    string url = (@"https://gmail.google.com/gmail/feed/atom");
    
