# Continuous Deployment
## What is Continuous Deployment?
-  Continuous deployment (CD, or CDE) is a strategy or methodology for software releases where any new code update or change that makes it through the rigorous automated test process is deployed directly into the live production environment where it will be visible to customers.
-  Continuous deployment is a strategy in software development where code changes to an application are released automatically into the production environment. This automation is driven by a series of predefined tests. Once new updates pass those tests, the system pushes the updates directly to the software's users.

## What is the goal of a continuous deployment process ?
- 1.To minimize the cycle time that is required to write a piece of code. 
- 2.Test it to ensure that it functions correctly and does not break the application,
- 3.Deploy it to the live environment and collect feedback on it from users.
**Important:**
- 	Automation is a key driver of productivity for teams that are doing continuous deployment. -A robust battery of automated tests must be programmed to verify that new code commits are functional before they are automated, and additional tools are required to abort the deployment process and trigger human intervention when the tests reveal lower-than-expected quality results or outcomes.
-	Continuous deployment adds an element of risk to the software release process- as developers are frequently committing unproven code which could potentially contain bugs to the live environment. Organizations that implement continuous deployment must therefore develop real-time monitoring capabilities of the live environment to rapidly discover and address any technical issues that occur after a new release.
## Continuous Integration vs Continuous Deployment
- 	Continuous integration refers to the software engineering practice of merging all of the output from software development teams into a shared mainline several times daily.
-  The practice originated in the early 1990's with an over-arching purpose of preventing integration problems in the software development process that would result when development
## Why Should developers teams practice continuous integration?
- 1.	To avoid integration issues - by ensuring that their working copies are merged into the main code bank several times each day. These regular commits reduce the number of conflicting changes, and any discovered conflicts are small and can usually be fixed relatively quickly. 
- 2. In contrast, developer teams that only commit changes once per week or once per month can build up a lot of conflicts between builds, leading to more difficulties when integrating the code.
- Continuous deployment takes CI a step further and automates the code release process so that each time new commits are merged into the mainline, automated testing is conducted and a pass results in the update being pushed to the production environment. 
- The key to achieving continuous deployment is to start with a functioning work flow for continuous integration, then streamline and automate the application release process so you can roll out new releases on a regular basis.
**What is the difference between Continuous Deployment vs DevOps?**
- DevOps is a set of software development practices with an emphasis in shortening software development cycle times and time-to-value while frequently delivering updates and new features. 
- Continuous deployment strives to deliver frequent updates as well, but it does so through a specific approach to change integration and delivery that minimizes lead times and relies on automation to facilitate frequent testing and software releases.
- continuous deployment describes a single practice for software development,while  DevOps offers an entire range of processes and best practices that are designed to help dev teams deliver code quickly that is tightly aligned with business strategy and objectives.
- The DevOps framework includes third-party software recommendations for every stage of the product development process and guidelines for establishing a strong DevOps culture within your organization. These characteristics of DevOps are well beyond the scope of Continuous Deployment.
**What are the Benefits of Continuous Deployment?**
- 1.Maintain Capability for Quick New Releases
The most important feature of continuous deployment is that is enables developer teams to get their new releases into the production environment as quickly as possible. Most software companies can no longer rely on development methodologies that were common when developers released software updates once per year. Some companies are rolling out up to 10 deployments per day with continuous deployment.
- 2.Enable a More Rapid Feedback Loop with Customers
More frequent updates to your application means a shorter feedback loop with the customer. Using state-of-the-art monitoring tools, developer teams can assess the impact of a new change on user behavior or engagement and make adjustments accordingly. The ability to rapidly release changes is an asset when customer behavior indicates the need for a quick pivot or change in strategy.
- 3.Reducing Manual Processes with Automation
Continuous deployment is defined by its use of automation in the application deployment process. In fact, continuous deployment wants developers to automate the entire software development process to the greatest extent possible, especially when it comes to release testing. Automation doesn't just help developers push out new releases faster, they actually spend less time on manual processes and get more work done.

**Continuous deployment vs. continuous delivery**

- Continuous delivery is a software development practice where software is built in such a way that it can be released into production at any given time. 
## How do you accomplish this?
- 1 By making sure  continuous delivery model involves production-like test environments. 
- 2.By making sure New builds performed in a continuous delivery solution are automatically deployed into an automatic quality-assurance testing environment that tests for any number of errors and inconsistencies. 
- 3. After the code passes all tests, continuous delivery requires human intervention to approve deployments into production. 
- 4.The deployment itself is then performed by automation.
.
- Continuous deployment is the natural outcome of continuous delivery done well.
- Continuous deployment tools
- To continuously develop and deploy high-quality software improvements, developers must use the appropriate tools for building effective DevOps practices. Doing so not only ensures efficient communication between both developmental and operational departments but also minimizes or eliminates errors in the software delivery pipeline.
 **Some of the most crucial tools used in a continuous deployment workflow:**
**Version control:** Version control helps with continuous integration by tracking revisions to a particular project’s assets. Also known as “revision" or “source” control, version control helps to improve visibility of a project's updates and changes while helping teams collaborate regardless of where and when they work.
**Code review** As simple as it sounds, “code review” is a process of using tools to test the current source code. Code reviews help improve the integrity of software by finding bugs and errors in coding and help developers address these issues before deploying updates.
**Continuous integration (CI):** CI is a critical component of continuous deployment and plays a major part in minimizing development roadblocks when multiple developers work on the same project. A variety of proprietary and open source CI tools exist, each catering to the unique complexities of enterprise software deployments.
	**Configuration management:** Configuration management is the strategy and discipline of making sure all software and hardware maintain a consistent state. This includes proper configuration and automation of all servers, storage, networking, and software.
	**Release automation:** Application release automation (or application release orchestration) is very important when automating all of the activities necessary to drive continuous deployment. Orchestration tools connect processes to one another to ensure developers follow all necessary steps before pushing new changes to production. These tools work closely with configuration management processes to ensure that all project environments are properly provisioned and able to perform at their highest level.
	**Infrastructure monitoring:** When operating a continuous deployment model, it’s important to be able to visualize the data that lives in your testing environments. Infrastructure monitoring tools help you analyze application performance to see if changes you make have a positive or negative impact.
## What are Kubernetes?
- Kubernetes is a great open source solution to use when developing a continuous deployment pipeline.
## Why use Kubernetes? 
- 1.Because of its flexible, 
- 2.logical, and
- 3. intuitive user interface, 
- 4. Kubernetes makes it possible to reduce the common problems that arise when running into server usage restrictions and outages while supporting modern infrastructure and multicloud deployments.

## What are the importance of Kubernetes?
- 1.	Kubernetes helps increase the agility of DevOps processes. Because of its modular design, Kubernetes allows alteration of individual pods inside a service, as well as seamless transitions between pods. This flexibility helps development teams avoid server downtime and allows for maximum resource utilization when running microservices.
- 2.	 Kubernetes is also an extremely reliable platform that can detect the readiness and overall health of applications and services before they’re deployed to the public.
- Continuous deployment across diverse applications
- When creating continuous delivery or continuous deployment infrastructure, it’s important to source the right enterprise solution that will give your business the confidence it needs to automate software testing and deployment processes. IBM UrbanCode Deploy is an application deployment automation platform that provides the visibility, traceability, and auditing capabilities businesses need to drive their software development needs in one optimized package.
**Multicloud deployments**
- Using UrbanCode Deploy’s Easy Process and Blueprint Designer, organizations can create custom cloud environment models to visualize how their applications should be deployed to public, private, and hybrid cloud. 
- Blueprint Designer allows users to create, update, and break down full-stack computing environments while enabling full cloud orchestration capabilities. All environments can then be provisioned to deploy application components automatically or on demand.
**Distributed automation**
**UrbanCode Deploy** is a highly scalable solution that supports the dynamic deployment of all mission-critical applications and services. Architected to meet the unique requirements of enterprises deploying across multiple data centers, UrbanCode Deploy supports master server clustering and uses lightweight deployments to provide immediate availability of services.
## Quality gates and approvals
- Being able to rely on the accuracy of automated testing environments is absolutely critical to successfully achieving continuous deployment. For some environments, however, it’s necessary to create certain conditions that flag manual approvals to ensure that the right information is pushed to production at the right time. UrbanCode Deploy features deployment approvals and gates to give administrators more control, visibility, and auditing capabilities over their continuous deployment processes.
**Tested integrations**
- While UrbanCode Deploy supports the use of your own scripts, out-of-the-box plugins make deployment processes easier to design and manage. By using tested integrations, developers can utilize pre-built automation that has already been proven. This replaces the need to create custom scripts specifically for UrbanCode Deploy.
- IBM UrbanCode Deploy features advanced process orchestration and collaboration tools that make it possible for enterprises to organize all of their deployment needs in one easy-to-use, customizable dashboard. Whether deploying applications on-premise, off-premise, or across thousands of managed servers, UrbanCode Deploy gives you all the solutions you need to ensure continuous delivery and rapid deployment across your entire enterprise.
.
**Continuous deployment and IBM Cloud**
The ability to release code changes automatically into the production environment can help dramatically speed time to market. You can do this with IBM tools as well as integrations with third parties and open source plugins. IBM processes and tools can help you with one of the most challenging DevOps initiatives organizations face—building and modernizing applications on the journey to cloud.
Reference Links
https://www.sumologic.com/glossary/continuous-deployment/
https://www.ibm.com/cloud/learn/continuous-deployment   


