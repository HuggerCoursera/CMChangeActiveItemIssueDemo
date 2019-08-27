# CMChangeActiveItemIssueDemo

Demo project that shows issue with Caliburn.Micro's Conductor.OneActive type due to which on calling ChangeActiveItem with closePrevious:=true previous conducted item actually doesn't become removed from Conductor's Items collection.
