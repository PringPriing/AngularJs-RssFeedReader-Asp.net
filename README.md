Acceptance Criteria

Create an application that periodically reads the rss feeds from http://www.sunstar.com.ph/rss/cebu
Reads the feeds every 5 minutes, and update the UI acoordingly whenever new updates come in.
The app supports authentication and authorization
Each rss entry can be rated by the user using star rating. if an entry is marked as five star then it must
remmeber the rating when the user logs back in. (by default, star rating is 0 on each feed)
If a feed is outdated and does not exist on the feed, then it will not show up anymore on the list even if there is a star rating on it.
