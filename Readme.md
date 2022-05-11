# Continuous Deployment
## What is Continuous Deployment?
- Continuous deployment (CD, or CDE) is a strategy or methodology for software releases where any new code update or change that makes it through the rigorous automated test process is deployed directly into the live production environment where it will be visible to customers.
 **The goal of a continuous deployment process is simple:**
- 1.	To minimize the cycle time that is required to write a piece of code. 
- 2.	Test it to ensure that it functions correctly and does not break the application,
- 3.	 Deploy it to the live environment and collect feedback on it from users.
-  Automation is a key driver of productivity for teams that are doing continuous deployment. A robust battery of automated tests must be programmed to verify that
-new code commits are functional before they are automated, and additional tools are required to abort the deployment process and trigger human intervention when the 
-tests reveal lower-than-expected quality results or outcomes.
Continuous deployment adds an element of risk to the software release process, as developers are frequently committing unproven code which could potentially 
-contain bugs to the live environment. Organizations that implement continuous deployment must therefore develop real-time monitoring capabilities of the live 
-environment to rapidly discover and address any technical issues that occur after a new release.
**Continuous Integration vs Continuous Deployment**
- Continuous integration refers to the software engineering practice of merging all of the output from software development teams into a shared mainline several times daily. 
- The practice originated in the early 1990's with an over-arching purpose of preventing integration problems in the software development process that would result when development
In the past, a software developer working on an application would obtain a copy of the current code base to build and test a change. As the code base was constantly being updated by other developers, 
- this copy of the code base would become increasingly out-of-date over time. Still, the developer would build and test their change, but the final step was always to 
integrate the change back into the code base.
- This always created a problem though - sometimes, the code base had changed significantly since the original copy of it was made, which could lead to problems when integrating the developer code back into the main line. 
- Sometimes, the newly implemented changes included resources that conflicted with other code in the code base, which meant more integration problems. 
- In some cases, developers would spend more time integrating their newly implemented changes back into the main code base than they had implementing the actual changes in the first place.
**Developer teams that practice continuous integration**
1.	Avoid integration issues by ensuring that their working copies are merged into the main code bank several times each day. These regular commits reduce the number of conflicting changes, and any discovered conflicts are small and can usually be fixed relatively quickly. 
2.	In contrast, developer teams that only commit changes once per week or once per month can build up a lot of conflicts between builds, leading to more difficulties when integrating the code.
•	Continuous deployment takes CI a step further and automates the code release process so that each time new commits are merged into the mainline, automated testing is conducted and a pass results in the update being pushed to the production environment. 
•	 The key to achieving continuous deployment is to start with a functioning work flow for continuous integration, then streamline and automate the application release process so you can roll out new releases on a regular basis.
**Continuous Deployment vs DevOps**
Continuous deployment and DevOps are not the same thing, but they aren't necessarily mutually exclusive either and software developers can actually achieve some pretty interesting results by leveraging both paradigms.
For starters, it's clear that continuous deployment and DevOps have similar goals. 
- 	DevOps is a set of software development practices with an emphasis in shortening software development cycle times and time-to-value while frequently delivering updates and new features. 
 - Continuous deployment strives to deliver frequent updates as well, but it does so through a specific approach to change integration and delivery that minimizes lead times and relies on automation to facilitate frequent testing and software releases.
Ultimately, 
## Difference between Continuous deployment and DevOps
-  continuous deployment describes a single practice for software development, 
-  DevOps offers an entire range of processes and best practices that are designed to help dev teams deliver code quickly that is tightly aligned with business strategy and objectives. 
  - The DevOps framework includes third-party software recommendations for every stage of the product development process and guidelines for establishing a strong DevOps culture within your organization. These characteristics of DevOps are well beyond the scope of Continuous Deployment.
**What are the Benefits of Continuous Deployment?**
## Why are more software developers moving beyond the continuous integration model and working towards continuous delivery and continuous deployment? 
- The combination of continuous development and DevOps can enable lightning-speed releases, but that's not the only benefit that organizations are seeing from their adoption of CD. 
**Here are just a few benefits of continuous deployment:**
- 1.Maintain Capability for Quick New Releases
The most important feature of continuous deployment is that is enables developer teams to get their new releases into the production environment as quickly as possible. Most software companies can no longer rely on development methodologies that were common when developers released software updates once per year. Some companies are rolling out up to 10 deployments per day with continuous deployment.
- 2.Enable a More Rapid Feedback Loop with Customers
More frequent updates to your application means a shorter feedback loop with the customer. Using state-of-the-art monitoring tools, developer teams can assess the impact of a new change on user behavior or engagement and make adjustments accordingly. The ability to rapidly release changes is an asset when customer behavior indicates the need for a quick pivot or change in strategy.
- 3.Reducing Manual Processes with Automation
Continuous deployment is defined by its use of automation in the application deployment process. In fact, continuous deployment wants developers to automate the entire software development process to the greatest extent possible, especially when it comes to release testing. Automation doesn't just help developers push out new releases faster, they actually spend less time on manual processes and get more work done.
Reference Links
https://www.sumologic.com/glossary/continuous-deployment/
