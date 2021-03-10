# Purge Unused Assets

Sometimes our projects get cluttered with assets that are not being used in-game,
but we cannot really delete them because retrieving them can be difficult if they
are needed later on.
Use this package on the release branch of your project to remove any unnecessary
assets.
This project only deletes assets specifically marked for deletion.

You can mark assets for deletion by attaching the **UnusedAsset** script to them.

Then you can run **Tools/Purge Unused Assets/Purge Assets** to delete the assets.