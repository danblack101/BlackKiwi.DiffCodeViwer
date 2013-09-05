namespace BlackKiwi.CodeDiffViewer.Tests
{
    public class TestConstants
    {
        public const string OneFile = @"diff -r d24543158aac -r 357ea03eef4c .hgignore
--- a/.hgignore	Mon Sep 02 09:57:29 2013 +1200
+++ b/.hgignore	Fri Aug 30 14:37:14 2013 +1200
@@ -1,11 +1,8 @@
 syntax: glob
 Solution/_ReSharper.*
 *.user
-*.suo
 Solution/Diligent.Boardbooks.suo
 [Bb]in
-**/[Bb]in
-**/[Oo]bj
 [Dd]debug*/
 [Rr]elease*/
 Solution/Services/*/Proxy/*Proxy.cs";

        public const string TwoFiles = @"diff -r d24543158aac -r 357ea03eef4c .hgignore
--- a/.hgignore	Mon Sep 02 09:57:29 2013 +1200
+++ b/.hgignore	Fri Aug 30 14:37:14 2013 +1200
@@ -1,11 +1,8 @@
 syntax: glob
 Solution/_ReSharper.*
 *.user
-*.suo
 Solution/Diligent.Boardbooks.suo
 [Bb]in
-**/[Bb]in
-**/[Oo]bj
 [Dd]debug*/
 [Rr]elease*/
 Solution/Services/*/Proxy/*Proxy.cs
@@ -25,9 +22,6 @@
 Solution/buildMetaData.xml
 Solution/Services/iPadService/Logging.config
 Solution/Services/iPadService/KeyManagementServers.config
-Solution/Backup*
-Solution/_UpgradeReport*
-ClientServicesPortal/solution/**/iBatis
 syntax: regexp
 Solution/.*/obj/.*
 Solution/Installed Service/.*
diff -r d24543158aac -r 357ea03eef4c Database/SitesUpgradeScript.xml
--- a/Database/SitesUpgradeScript.xml	Mon Sep 02 09:57:29 2013 +1200
+++ b/Database/SitesUpgradeScript.xml	Fri Aug 30 14:37:14 2013 +1200
@@ -941,62 +941,4 @@
 			</statement>
 		</statements>
 	</script>
-	<script>
-	   <purpose>New Tables for Mobile Partnerships to hold Authorized devices and pending authorizations</purpose>
-		<author>DB</author>
-		<identifier>1</identifier>
-		<statements>
-			<statement>
-				CREATE TABLE AuthorizedDevice
-				(
-					AuthorizedDeviceId int IDENTITY(1,1) NOT NULL,
-					SiteId int NOT NULL,
-					UserId int NOT NULL,
-					DeviceType varchar(50) NOT NULL,
-					Description varchar(1000) NOT NULL,
-					AuthorizationDate datetime NOT NULL,
-					DeviceId varchar(50) NOT NULL,
-					PublicKey varbinary(255) NOT NULL,
-					MachineId varchar(50) NULL,
-					Status varchar(50) NOT NULL,
-					RowHash varbinary(100) NOT NULL,
-					CONSTRAINT PK_AuthorizedDevice PRIMARY KEY CLUSTERED (AuthorizedDeviceId),
-					
-				)
-			</statement>
-			<statement>
-				CREATE TABLE AuthorizedDeviceRequest
-				(
-					AuthorizedDeviceRequestId int IDENTITY(1,1) NOT NULL,
-					SiteId int NOT NULL,
-					UserId int NOT NULL,
-					DeviceType varchar(50) NOT NULL,
-					Description varchar(1000) NOT NULL,
-					Overlap varchar(1000) NULL,
-					DeviceId varchar(50) NOT NULL,
-					PublicKey varbinary(255) NOT NULL,
-					MachineId varchar(50) NULL,
-					Pin int NULL,
-					PinAttempts int NULL,
-					PinExpiryUTC datetime NULL,
-					CONSTRAINT PK_PendingAuthorizationRequest PRIMARY KEY CLUSTERED (AuthorizedDeviceRequestId)
-				)
-			</statement>
-			<statement>
-				ALTER TABLE Site ADD
-				AuthDeviceRequirement int NOT NULL,
-				AuthAdminDeviceAccessibility int NOT NULL,
-				AuthDirectorDeviceAccessibility int NOT NULL,
-				AuthDeviceRestriction varchar(1000) NOT NULL,
-				AuthCustomerNotificationEmail varchar(100) NULL
-			</statement>
-			<statement>
-				ALTER TABLE UserSession ADD
-					AuthNonce varchar(1000) NULL,
-					AuthDeviceId varbinary(1000) NULL,
-					AuthDeviceStatus varchar(100) NULL,
-					AuthAccessibleSites varchar(1000) NULL
-			</statement>
-		</statements>
-	</script>
 </scripts>";
    }
}