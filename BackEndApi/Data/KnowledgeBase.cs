using System.Runtime.CompilerServices;
using BackEndApi.Models;

namespace BackEndApi.Data;

/// <summary>
/// Seed chunks for keyword retrieval. Later: load from files or a database at startup.
/// </summary>
public static class KnowledgeBase
{
    public static IReadOnlyList<DocumentChunk> Chunks { get; } =
    [
        new DocumentChunk("kb-hours", "faq.txt", "Office hours are 9AM to 5PM Monday through Friday."),
        new DocumentChunk("kb-donate", "faq.txt", "Donations are tax-free under section applicable to registered charities."),
        new DocumentChunk("kb-support", "faq.txt", "Support email is support@church.com for technical issues."),
        new DocumentChunk("kb-hours", "faq.txt", "Office hours are 9AM to 5PM Monday through Friday."),
        new DocumentChunk("kb-donate", "faq.txt", "Donations are tax-free under section applicable to registered charities."),
        new DocumentChunk("kb-support", "faq.txt", "Support email is support@church.com for technical issues."),
        new DocumentChunk("kb-location", "faq.txt", "The church is located at 15 Main Street, Chennai."),
        new DocumentChunk("kb-prayer", "faq.txt", "Weekly prayer meetings are held every Wednesday at 7PM."),
        new DocumentChunk("kb-youth", "faq.txt", "Youth fellowship starts every Saturday evening at 5PM."),
        new DocumentChunk("kb-baptism", "faq.txt", "Baptism classes are conducted on the first Sunday of every month."),
        new DocumentChunk("kb-marriage", "faq.txt", "Marriage registration support is available through the church office."),
        new DocumentChunk("kb-library", "faq.txt", "The church library is open after Sunday service until 2PM."),
        new DocumentChunk("kb-contact", "faq.txt", "You can contact the reception desk at +91-9876543210."),
        new DocumentChunk("kb-food", "faq.txt", "Free food distribution happens every Friday afternoon."),
        new DocumentChunk("kb-membership", "faq.txt", "Membership applications can be submitted online or at the office."),
        new DocumentChunk("kb-events", "faq.txt", "Upcoming church events are listed on the community notice board."),
        new DocumentChunk("kb-stream", "faq.txt", "Sunday services are streamed live on the official YouTube channel."),
        new DocumentChunk("kb-choir", "faq.txt", "Choir practice takes place every Thursday at 6PM."),
        new DocumentChunk("kb-volunteer", "faq.txt", "Volunteers are welcome for teaching, cleaning, and event management."),
        new DocumentChunk("kb-parking", "faq.txt", "Parking is available behind the church building for visitors."),
        new DocumentChunk("kb-security", "faq.txt", "Security staff are available during all major church events."),
        new DocumentChunk("kb-wifi", "faq.txt", "Guest WiFi password can be collected from the reception counter."),
        new DocumentChunk("kb-children", "faq.txt", "Children's Bible classes are available during Sunday worship."),
        new DocumentChunk("kb-transport", "faq.txt", "Transport service is available for elderly members on Sundays."),
        new DocumentChunk("kb-counseling", "faq.txt", "Personal counseling sessions can be booked through the admin office."),
        new DocumentChunk("kb-fasting", "faq.txt", "Monthly fasting prayer is conducted on the last Friday of every month."),
        new DocumentChunk("kb-bible", "faq.txt", "Bible study sessions begin daily at 6AM online."),
        new DocumentChunk("kb-cleaning", "faq.txt", "Cleaning staff maintain the prayer hall every morning."),
        new DocumentChunk("kb-offering", "faq.txt", "Online offerings can be made through UPI and bank transfer."),
        new DocumentChunk("kb-visitors", "faq.txt", "Visitors are requested to register at the welcome desk."),
        new DocumentChunk("kb-medical", "faq.txt", "Basic first aid support is available inside the church campus."),
        new DocumentChunk("kb-retreat", "faq.txt", "Annual spiritual retreat registrations open every December."),
        new DocumentChunk("kb-language", "faq.txt", "Services are available in both Tamil and English languages."),
        new DocumentChunk("office-hours", "office-faq.txt", "Office working hours are from 9AM to 6PM Monday through Friday."),
        new DocumentChunk("office-weekend", "office-faq.txt", "The office remains closed on Saturdays and Sundays."),
        new DocumentChunk("office-lunch", "office-faq.txt", "Lunch break timings are from 1PM to 2PM."),
        new DocumentChunk("office-location", "office-faq.txt", "The head office is located in Chennai, Tamil Nadu."),
        new DocumentChunk("office-contact", "office-faq.txt", "Employees can contact the reception desk at extension 101."),
        new DocumentChunk("office-email", "office-faq.txt", "General office inquiries can be sent to support@company.com."),
        new DocumentChunk("office-idcard", "office-faq.txt", "Employees must wear their ID cards inside the office premises."),
        new DocumentChunk("office-attendance", "office-faq.txt", "Attendance must be marked before 9:15AM every working day."),
        new DocumentChunk("office-leave", "office-faq.txt", "Leave requests should be submitted through the HR portal."),
        new DocumentChunk("office-salary", "office-faq.txt", "Salary will be credited on the last working day of every month."),
        new DocumentChunk("office-holiday", "office-faq.txt", "Public holiday announcements are shared through official email."),
        new DocumentChunk("office-wifi", "office-faq.txt", "Office WiFi credentials can be collected from the IT team."),
        new DocumentChunk("office-laptop", "office-faq.txt", "Employees are responsible for maintaining assigned office laptops."),
        new DocumentChunk("office-it-support", "office-faq.txt", "Technical issues should be reported to the IT support team."),
        new DocumentChunk("office-meeting", "office-faq.txt", "Meeting rooms must be booked through the internal booking system."),
        new DocumentChunk("office-security", "office-faq.txt", "Security checks are mandatory while entering the office campus."),
        new DocumentChunk("office-parking", "office-faq.txt", "Parking slots are allocated based on employee designation."),
        new DocumentChunk("office-food", "office-faq.txt", "The cafeteria serves breakfast, lunch, and evening snacks."),
        new DocumentChunk("office-remote", "office-faq.txt", "Remote work requests require manager approval."),
        new DocumentChunk("office-shift", "office-faq.txt", "Shift timings vary depending on the assigned project."),
        new DocumentChunk("office-training", "office-faq.txt", "Employee training sessions are conducted every quarter."),
        new DocumentChunk("office-probation", "office-faq.txt", "The probation period for new employees is six months."),
        new DocumentChunk("office-resignation", "office-faq.txt", "Employees must provide 30 days notice before resignation."),
        new DocumentChunk("office-payslip", "office-faq.txt", "Payslips can be downloaded from the employee self-service portal."),
        new DocumentChunk("office-internet", "office-faq.txt", "Personal browsing on office internet should be limited."),
        new DocumentChunk("office-policy", "office-faq.txt", "Employees must follow the company code of conduct policy."),
        new DocumentChunk("office-assets", "office-faq.txt", "All company assets must be returned during employee exit."),
        new DocumentChunk("office-access", "office-faq.txt", "Access cards are required to enter restricted office areas."),
        new DocumentChunk("office-recruitment", "office-faq.txt", "Open job positions are listed on the company careers portal."),
        new DocumentChunk("office-visitor", "office-faq.txt", "Visitors must sign in at the reception before entering."),
        new DocumentChunk("office-health", "office-faq.txt", "Health insurance benefits are available for full-time employees."),
        new DocumentChunk("office-travel", "office-faq.txt", "Business travel expenses can be claimed through finance."),
        new DocumentChunk("office-reimbursement", "office-faq.txt", "Expense reimbursements are processed within seven working days."),
        new DocumentChunk("office-feedback", "office-faq.txt", "Employees can submit anonymous feedback through the HR system."),
        new DocumentChunk("office-appraisal", "office-faq.txt", "Performance appraisals are conducted once every year."),
        new DocumentChunk("office-team", "office-faq.txt", "Team meetings are conducted every Monday morning."),
        new DocumentChunk("office-transport", "office-faq.txt", "Transport facilities are available for night shift employees."),
        new DocumentChunk("office-emergency", "office-faq.txt", "Emergency exits are marked clearly on every office floor."),
        new DocumentChunk("office-biometric", "office-faq.txt", "Biometric attendance is mandatory for all employees."),
        new DocumentChunk("office-confidential", "office-faq.txt", "Company confidential information must not be shared externally."),
        new DocumentChunk("office-project", "office-faq.txt", "Project allocation depends on business requirements."),
        new DocumentChunk("office-intern", "office-faq.txt", "Interns must report to their assigned mentors daily."),
        new DocumentChunk("office-overtime", "office-faq.txt", "Overtime work requires prior manager approval."),
        new DocumentChunk("office-dresscode", "office-faq.txt", "Employees should follow the formal dress code policy."),
        new DocumentChunk("office-announcement", "office-faq.txt", "Important announcements are shared through Microsoft Teams."),
        new DocumentChunk("office-vpn", "office-faq.txt", "VPN access is required for secure remote connections."),
        new DocumentChunk("office-password", "office-faq.txt", "Passwords should be changed every 90 days."),
        new DocumentChunk("office-printer", "office-faq.txt", "Printer access is managed through employee ID authentication."),
        new DocumentChunk("office-onboarding", "office-faq.txt", "New employee onboarding takes place every Monday."),
        new DocumentChunk("office-exit", "office-faq.txt", "Exit interviews are conducted by the HR department."),
        /*PolicyService*/
        new DocumentChunk("policy-attendance", "policies.txt", "Employees must mark attendance before 9:15AM daily."),
        new DocumentChunk("policy-leave", "policies.txt", "All leave requests require manager approval."),
        new DocumentChunk("policy-dresscode", "policies.txt", "Formal dress code is mandatory from Monday to Thursday."),
        new DocumentChunk("policy-security", "policies.txt", "Employees must carry ID cards inside office premises."),
        new DocumentChunk("policy-remote", "policies.txt", "Work from home is allowed only with prior approval."),
        new DocumentChunk("policy-password", "policies.txt", "Passwords must be updated every 90 days."),
        new DocumentChunk("policy-internet", "policies.txt", "Personal browsing should be limited during working hours."),
        new DocumentChunk("policy-confidential", "policies.txt", "Company confidential data must not be shared externally."),
        new DocumentChunk("policy-laptop", "policies.txt", "Employees are responsible for assigned office devices."),
        new DocumentChunk("policy-overtime", "policies.txt", "Overtime work requires reporting to the HR system."),
        new DocumentChunk("policy-meeting", "policies.txt", "Meeting rooms should be reserved before use."),
        new DocumentChunk("policy-visitor", "policies.txt", "Visitors must register at the reception desk."),
        new DocumentChunk("policy-parking", "policies.txt", "Parking allocation depends on employee grade."),
        new DocumentChunk("policy-email", "policies.txt", "Official communication must use company email accounts."),
        new DocumentChunk("policy-exit", "policies.txt", "Employees must return company assets during resignation."),
        /*HolidayList*/
        new DocumentChunk("holiday-newyear", "holidays.txt", "New Year holiday is observed on January 1."),
        new DocumentChunk("holiday-pongal", "holidays.txt", "Pongal holidays are provided for three consecutive days."),
        new DocumentChunk("holiday-republic", "holidays.txt", "Republic Day holiday is observed on January 26."),
        new DocumentChunk("holiday-goodfriday", "holidays.txt", "Good Friday is declared as a company holiday."),
        new DocumentChunk("holiday-mayday", "holidays.txt", "Labour Day holiday is observed on May 1."),
        new DocumentChunk("holiday-independence", "holidays.txt", "Independence Day holiday is observed on August 15."),
        new DocumentChunk("holiday-ganesh", "holidays.txt", "Ganesh Chaturthi is declared as an optional holiday."),
        new DocumentChunk("holiday-gandhi", "holidays.txt", "Gandhi Jayanthi holiday is observed on October 2."),
        new DocumentChunk("holiday-diwali", "holidays.txt", "Diwali holidays are announced based on festival dates."),
        new DocumentChunk("holiday-christmas", "holidays.txt", "Christmas holiday is observed on December 25."),
        new DocumentChunk("holiday-weekend", "holidays.txt", "Saturday and Sunday are weekly holidays."),
        new DocumentChunk("holiday-festival", "holidays.txt", "Festival holidays are communicated through official email."),
        new DocumentChunk("holiday-optional", "holidays.txt", "Employees may choose two optional holidays every year."),
        new DocumentChunk("holiday-carryforward", "holidays.txt", "Unused optional holidays cannot be carried forward."),
        new DocumentChunk("holiday-announcement", "holidays.txt", "Annual holiday calendars are released by HR in January."),
        /*Insurance*/
        new DocumentChunk("insurance-health", "insurance.txt", "Health insurance coverage is provided for all permanent employees."),
        new DocumentChunk("insurance-family", "insurance.txt", "Employees can include spouse and children in insurance plans."),
        new DocumentChunk("insurance-claim", "insurance.txt", "Insurance claims must be submitted within 30 days."),
        new DocumentChunk("insurance-hospital", "insurance.txt", "Cashless treatment is available at network hospitals."),
        new DocumentChunk("insurance-card", "insurance.txt", "Employees receive digital insurance cards after onboarding."),
        new DocumentChunk("insurance-accident", "insurance.txt", "Accidental insurance coverage is included in employee benefits."),
        new DocumentChunk("insurance-life", "insurance.txt", "Life insurance benefits are available for eligible employees."),
        new DocumentChunk("insurance-premium", "insurance.txt", "Insurance premiums are partially covered by the company."),
        new DocumentChunk("insurance-renewal", "insurance.txt", "Insurance policies are renewed every financial year."),
        new DocumentChunk("insurance-support", "insurance.txt", "Employees can contact HR for insurance assistance."),
        new DocumentChunk("insurance-dental", "insurance.txt", "Dental coverage is available under premium insurance plans."),
        new DocumentChunk("insurance-emergency", "insurance.txt", "Emergency ambulance charges are covered by insurance."),
        new DocumentChunk("insurance-documents", "insurance.txt", "Medical bills and discharge summaries are required for claims."),
        new DocumentChunk("insurance-limit", "insurance.txt", "Insurance claim limits depend on employee grade."),
        new DocumentChunk("insurance-maternity", "insurance.txt", "Maternity coverage is included for eligible employees."),
        /*Upcoming holidays*/
        new DocumentChunk("holiday-upcoming-1", "upcoming-holidays.txt", "The next company holiday is Independence Day on August 15."),
        new DocumentChunk("holiday-upcoming-2", "upcoming-holidays.txt", "The upcoming optional holiday is Ganesh Chaturthi next month."),
        new DocumentChunk("holiday-upcoming-3", "upcoming-holidays.txt", "Employees will receive a long weekend during Diwali holidays."),
        new DocumentChunk("holiday-upcoming-4", "upcoming-holidays.txt", "The office will remain closed for Christmas celebrations on December 25."),
        new DocumentChunk("holiday-upcoming-5", "upcoming-holidays.txt", "New Year holiday leave starts from January 1."),
        new DocumentChunk("holiday-upcoming-6", "upcoming-holidays.txt", "The HR team will announce festival holidays before every quarter."),
        new DocumentChunk("holiday-upcoming-7", "upcoming-holidays.txt", "Employees can check upcoming holidays in the HR portal."),
        new DocumentChunk("holiday-upcoming-8", "upcoming-holidays.txt", "The next public holiday will be notified through company email."),
        new DocumentChunk("holiday-upcoming-9", "upcoming-holidays.txt", "Special holiday leave may be announced for regional festivals."),
        new DocumentChunk("holiday-upcoming-10", "upcoming-holidays.txt", "Upcoming holiday schedules are updated every month by HR."),
        new DocumentChunk("holiday-upcoming-11", "upcoming-holidays.txt", "Employees are advised to plan leave based on the upcoming holiday calendar."),
        new DocumentChunk("holiday-upcoming-12", "upcoming-holidays.txt", "Holiday notifications are available in Microsoft Teams announcements."),
        new DocumentChunk("holiday-upcoming-13", "upcoming-holidays.txt", "The office may declare additional holidays during national events."),
        new DocumentChunk("holiday-upcoming-14", "upcoming-holidays.txt", "Festival holiday dates may vary depending on government announcements."),
        new DocumentChunk("holiday-upcoming-15", "upcoming-holidays.txt", "Employees can combine optional leave with upcoming holidays for long weekends."),
        /*  Frequently Asked!*/
        new DocumentChunk("ans-salary-date", "faq-answers.txt", "Salary is credited on the last working day of every month."),
        new DocumentChunk("ans-payslip", "faq-answers.txt", "Payslips can be downloaded from the employee self-service portal."),
        new DocumentChunk("ans-leave-balance", "faq-answers.txt", "Employees can check leave balance through the HR portal dashboard."),
        new DocumentChunk("ans-apply-leave", "faq-answers.txt", "Leave requests must be submitted through the HR management system."),
        new DocumentChunk("ans-upcoming-holiday", "faq-answers.txt", "The upcoming holiday list is available in the HR portal."),
        new DocumentChunk("ans-holiday-list", "faq-answers.txt", "Employees can download the annual holiday calendar from the company intranet."),
        new DocumentChunk("ans-wfh", "faq-answers.txt", "Work from home requests require approval from the reporting manager."),
        new DocumentChunk("ans-login-issue", "faq-answers.txt", "Employees should contact IT support for login related issues."),
        new DocumentChunk("ans-password-reset", "faq-answers.txt", "Passwords can be reset using the self-service password reset portal."),
        new DocumentChunk("ans-vpn", "faq-answers.txt", "VPN access details are provided by the IT department."),
        new DocumentChunk("ans-wifi", "faq-answers.txt", "Office WiFi credentials can be collected from the IT support desk."),
        new DocumentChunk("ans-laptop-issue", "faq-answers.txt", "Laptop issues should be reported immediately to the IT helpdesk."),
        new DocumentChunk("ans-it-support", "faq-answers.txt", "IT support can be reached through support@company.com."),
        new DocumentChunk("ans-insurance-card", "faq-answers.txt", "Insurance cards can be downloaded from the insurance provider portal."),
        new DocumentChunk("ans-insurance-claim", "faq-answers.txt", "Medical insurance claims must include bills and hospital documents."),
        new DocumentChunk("ans-office-time", "faq-answers.txt", "Office working hours are from 9AM to 6PM."),
        new DocumentChunk("ans-late-login", "faq-answers.txt", "Late attendance may require manager justification after repeated occurrences."),
        new DocumentChunk("ans-biometric", "faq-answers.txt", "Employees should report biometric issues to the administration team."),
        new DocumentChunk("ans-transport", "faq-answers.txt", "Transport services are available for eligible shift employees."),
        new DocumentChunk("ans-cab", "faq-answers.txt", "Cab booking requests can be made through the transport portal."),
        new DocumentChunk("ans-food", "faq-answers.txt", "The cafeteria operates from 8AM to 7PM on working days."),
        new DocumentChunk("ans-meeting-room", "faq-answers.txt", "Meeting rooms can be reserved using the internal booking system."),
        new DocumentChunk("ans-id-card", "faq-answers.txt", "Lost ID cards must be reported immediately to the security office."),
        new DocumentChunk("ans-resignation", "faq-answers.txt", "Resignation requests should be submitted through the HR portal."),
        new DocumentChunk("ans-notice-period", "faq-answers.txt", "The standard notice period is 30 days."),
        new DocumentChunk("ans-appraisal", "faq-answers.txt", "Performance appraisals are conducted annually."),
        new DocumentChunk("ans-bonus", "faq-answers.txt", "Annual bonuses are based on company and employee performance."),
        new DocumentChunk("ans-promotion", "faq-answers.txt", "Promotions are decided based on appraisal results and business needs."),
        new DocumentChunk("ans-policy", "faq-answers.txt", "Company policies are available in the employee handbook portal."),
        new DocumentChunk("ans-training", "faq-answers.txt", "Training schedules are shared through official company email."),
        new DocumentChunk("ans-intern", "faq-answers.txt", "Intern working hours are generally from 9AM to 5PM."),
        new DocumentChunk("ans-project", "faq-answers.txt", "Project allocation depends on skills, availability, and business requirements."),
        new DocumentChunk("ans-overtime", "faq-answers.txt", "Overtime compensation depends on company policy and manager approval."),
        new DocumentChunk("ans-reimbursement", "faq-answers.txt", "Employees can claim reimbursements through the finance portal."),
        new DocumentChunk("ans-hr-contact", "faq-answers.txt", "Employees can contact HR through hr@company.com."),
        new DocumentChunk("ans-emergency", "faq-answers.txt", "Emergency contact numbers are displayed on every office floor."),
        new DocumentChunk("ans-access-card", "faq-answers.txt", "Access card issues should be reported to the security team."),
        new DocumentChunk("ans-printer", "faq-answers.txt", "Employees can connect to printers using their office credentials."),
        new DocumentChunk("ans-email", "faq-answers.txt", "Company email can be accessed securely using VPN access."),
        new DocumentChunk("ans-onboarding", "faq-answers.txt", "New employees must submit ID proof, educational certificates, and bank details during onboarding."),

        /* ── Work From Home Policy ── */
        new DocumentChunk("wfh-eligibility", "wfh-policy.txt", "Work from home is available for employees who have completed their probation period of six months."),
        new DocumentChunk("wfh-request", "wfh-policy.txt", "WFH requests must be submitted at least one day in advance through the HR portal with a valid reason."),
        new DocumentChunk("wfh-approval", "wfh-policy.txt", "Work from home requests require approval from the immediate reporting manager before the requested date."),
        new DocumentChunk("wfh-limit", "wfh-policy.txt", "Employees are allowed a maximum of 8 work-from-home days per month, subject to project requirements."),
        new DocumentChunk("wfh-availability", "wfh-policy.txt", "Employees working from home must be reachable on Microsoft Teams and email during standard office hours (9AM–6PM)."),
        new DocumentChunk("wfh-attendance", "wfh-policy.txt", "WFH attendance must be logged through the HR portal before 9:15AM on the work-from-home day."),
        new DocumentChunk("wfh-equipment", "wfh-policy.txt", "Employees must use company-provided laptops and VPN connections while working from home for data security."),
        new DocumentChunk("wfh-internet", "wfh-policy.txt", "A stable internet connection of at least 10 Mbps is required for work-from-home days. Internet expenses are not reimbursed."),
        new DocumentChunk("wfh-meetings", "wfh-policy.txt", "Employees on WFH must join all scheduled meetings via video call with cameras turned on when requested by the manager."),
        new DocumentChunk("wfh-revoke", "wfh-policy.txt", "WFH privileges may be revoked if an employee is found unreachable or unproductive during remote working days."),
        new DocumentChunk("wfh-friday", "wfh-policy.txt", "Fridays are designated as optional WFH days company-wide, subject to team lead approval."),
        new DocumentChunk("wfh-hybrid", "wfh-policy.txt", "The company follows a hybrid work model: employees must be in office at least 3 days per week (Tuesday, Wednesday, and Thursday are mandatory in-office days)."),
        new DocumentChunk("wfh-emergency", "wfh-policy.txt", "Emergency WFH can be availed without prior approval, but the reporting manager must be informed within one hour of login."),

        /* ── Snacks & Pantry Policy ── */
        new DocumentChunk("snack-morning", "snacks-policy.txt", "Morning snacks are available in the pantry from 10:00AM to 10:30AM. Items include biscuits, bread toast, bananas, and tea/coffee."),
        new DocumentChunk("snack-evening", "snacks-policy.txt", "Evening snacks are served from 4:00PM to 4:30PM. Options include samosa, vada, sandwich, and beverages."),
        new DocumentChunk("snack-tea-coffee", "snacks-policy.txt", "Tea and coffee vending machines are available 24/7 on every floor. Each employee gets unlimited free beverages."),
        new DocumentChunk("snack-pantry-location", "snacks-policy.txt", "Pantry and snack counters are located on the 2nd and 5th floors near the break rooms."),
        new DocumentChunk("snack-special", "snacks-policy.txt", "Special snacks and sweets are provided during festivals, company celebrations, and employee birthdays."),
        new DocumentChunk("snack-vending", "snacks-policy.txt", "Vending machines with packaged snacks, juices, and energy drinks are available in the lobby area on every floor."),
        new DocumentChunk("snack-cost", "snacks-policy.txt", "Morning and evening snacks provided by the company are free of charge. Vending machine items are paid via employee ID card."),
        new DocumentChunk("snack-hygiene", "snacks-policy.txt", "Employees are requested to maintain cleanliness in the pantry area and dispose of waste in designated bins."),
        new DocumentChunk("snack-dietary", "snacks-policy.txt", "Vegetarian and non-vegetarian snack options are available separately. Employees with dietary restrictions can inform the admin team."),
        new DocumentChunk("snack-feedback", "snacks-policy.txt", "Snack quality feedback can be submitted through the facilities team email at facilities@company.com."),

        /* ── Lunch Time & Cafeteria Policy ── */
        new DocumentChunk("lunch-timing", "lunch-policy.txt", "Lunch break is from 1:00PM to 2:00PM for all employees. The cafeteria operates from 12:30PM to 2:30PM."),
        new DocumentChunk("lunch-cafeteria", "lunch-policy.txt", "The cafeteria is located on the ground floor and can accommodate up to 200 employees at a time."),
        new DocumentChunk("lunch-menu", "lunch-policy.txt", "The lunch menu rotates daily and includes rice, chapati, two curries, dal, salad, curd, and a dessert on Fridays."),
        new DocumentChunk("lunch-cost", "lunch-policy.txt", "Lunch meals are subsidized by the company. Employees pay Rs.30 per meal which is deducted from salary."),
        new DocumentChunk("lunch-booking", "lunch-policy.txt", "Employees must pre-book lunch through the cafeteria app by 10:30AM each day to avoid food wastage."),
        new DocumentChunk("lunch-veg-nonveg", "lunch-policy.txt", "Both vegetarian and non-vegetarian meal options are available. Non-veg meals are served on Tuesday, Thursday, and Friday."),
        new DocumentChunk("lunch-outside", "lunch-policy.txt", "Employees may bring food from outside. Microwave ovens are available in the pantry for reheating."),
        new DocumentChunk("lunch-extended", "lunch-policy.txt", "Extended lunch breaks beyond 2:00PM require prior intimation to the team lead and must be compensated with extra working time."),
        new DocumentChunk("lunch-guest", "lunch-policy.txt", "Guest meals can be arranged by informing the admin team at least 2 hours before lunch time. Guest meal cost is Rs.100."),
        new DocumentChunk("lunch-special-diet", "lunch-policy.txt", "Employees with specific dietary needs (Jain, gluten-free, etc.) can request customized meals by contacting the cafeteria manager."),
        new DocumentChunk("lunch-water", "lunch-policy.txt", "Purified drinking water dispensers are available on every floor and in the cafeteria area."),
        new DocumentChunk("lunch-takeaway", "lunch-policy.txt", "Takeaway lunch boxes are not permitted from the cafeteria. Meals should be consumed in the dining area."),

        /* ── Reporting Manager & Hierarchy ── */
        new DocumentChunk("mgr-reporting", "reporting-manager.txt", "Every employee is assigned a reporting manager during onboarding. The reporting manager is responsible for approvals, appraisals, and daily task oversight."),
        new DocumentChunk("mgr-hierarchy", "reporting-manager.txt", "The reporting hierarchy is: Intern → Junior Developer → Senior Developer → Team Lead → Project Manager → Delivery Head → CTO."),
        new DocumentChunk("mgr-change", "reporting-manager.txt", "Reporting manager changes happen during project reassignments or organizational restructuring. HR communicates the change via email."),
        new DocumentChunk("mgr-escalation", "reporting-manager.txt", "If an employee has concerns about their reporting manager, they can escalate to the skip-level manager or HR directly."),
        new DocumentChunk("mgr-one-on-one", "reporting-manager.txt", "Reporting managers conduct one-on-one meetings with each team member at least once every two weeks."),
        new DocumentChunk("mgr-approvals", "reporting-manager.txt", "Leave requests, WFH requests, overtime claims, and expense reimbursements require reporting manager approval."),
        new DocumentChunk("mgr-feedback", "reporting-manager.txt", "Employees receive quarterly performance feedback from their reporting manager through the appraisal system."),
        new DocumentChunk("mgr-skip-level", "reporting-manager.txt", "Skip-level meetings with the manager's manager are conducted once per quarter to ensure transparent communication."),
        new DocumentChunk("mgr-team-lead", "reporting-manager.txt", "Team leads are responsible for daily standups, sprint planning, code reviews, and resolving team blockers."),
        new DocumentChunk("mgr-pm", "reporting-manager.txt", "Project managers oversee project timelines, client communication, resource allocation, and delivery milestones."),
        new DocumentChunk("mgr-hr-bp", "reporting-manager.txt", "Each department has an assigned HR Business Partner who handles employee relations, grievances, and policy queries."),
        new DocumentChunk("mgr-find", "reporting-manager.txt", "Employees can find their reporting manager details in the HR portal under 'My Profile → Reporting Structure'."),

        /* ── Work Environment & Office Facilities ── */
        new DocumentChunk("env-floors", "office-environment.txt", "The office has 6 floors. Ground floor: reception and cafeteria. Floors 1–4: development teams. Floor 5: management and conference rooms."),
        new DocumentChunk("env-workstation", "office-environment.txt", "Each employee is assigned a dedicated workstation with a monitor, keyboard, mouse, and ergonomic chair."),
        new DocumentChunk("env-ac", "office-environment.txt", "All office floors are centrally air-conditioned. Temperature is maintained between 22°C and 24°C."),
        new DocumentChunk("env-meeting-rooms", "office-environment.txt", "There are 12 meeting rooms across the office: 4 small (4-seater), 4 medium (8-seater), and 4 large (20-seater) rooms."),
        new DocumentChunk("env-recreation", "office-environment.txt", "The recreation room on the 3rd floor has a table tennis table, carrom board, foosball table, and a PlayStation console."),
        new DocumentChunk("env-gym", "office-environment.txt", "A fully equipped gym is available on the 5th floor. It is open from 6AM to 9PM and free for all employees."),
        new DocumentChunk("env-smoking", "office-environment.txt", "Smoking is strictly prohibited inside the office building. A designated smoking zone is available in the parking area."),
        new DocumentChunk("env-restrooms", "office-environment.txt", "Restrooms are available on every floor and are cleaned three times a day by the housekeeping team."),
        new DocumentChunk("env-elevator", "office-environment.txt", "Two elevators and one staircase are available. Employees are encouraged to use stairs for floors within two levels."),
        new DocumentChunk("env-quiet-zone", "office-environment.txt", "A quiet work zone is available on the 4th floor for employees who need a distraction-free environment."),
        new DocumentChunk("env-phone-booth", "office-environment.txt", "Soundproof phone booths are available on each floor for private calls and client discussions."),
        new DocumentChunk("env-first-aid", "office-environment.txt", "First aid kits are available at the reception desk and on every floor near the fire exit."),
        new DocumentChunk("env-fire-safety", "office-environment.txt", "Fire extinguishers are placed on every floor. Fire safety drills are conducted once every quarter."),
        new DocumentChunk("env-cctv", "office-environment.txt", "The entire office campus is under CCTV surveillance for employee safety and security."),
        new DocumentChunk("env-power-backup", "office-environment.txt", "The office has uninterrupted power supply with diesel generator backup for emergency situations."),
        new DocumentChunk("env-bike-parking", "office-environment.txt", "Covered bike parking and separate car parking areas are available in the basement and ground level."),
        new DocumentChunk("env-green-zone", "office-environment.txt", "An outdoor garden and seating area is available on the terrace for breaks and informal discussions."),
        new DocumentChunk("env-lockers", "office-environment.txt", "Personal lockers are provided on each floor. Employees can request a locker through the admin portal."),

        /* ── IT Environment & Tools ── */
        new DocumentChunk("it-laptop", "it-environment.txt", "All developers receive a company laptop (Dell/Lenovo i7, 16GB RAM, 512GB SSD) configured by the IT team during onboarding."),
        new DocumentChunk("it-os", "it-environment.txt", "Standard operating systems are Windows 11 for general staff and Ubuntu/macOS for developers upon request."),
        new DocumentChunk("it-tools", "it-environment.txt", "Development tools include Visual Studio, VS Code, Git, Docker, Postman, and JIRA for project management."),
        new DocumentChunk("it-vpn", "it-environment.txt", "GlobalProtect VPN must be connected for accessing internal systems, repositories, and databases remotely."),
        new DocumentChunk("it-email", "it-environment.txt", "Company email is hosted on Microsoft 365. Outlook is the standard email client for all employees."),
        new DocumentChunk("it-teams", "it-environment.txt", "Microsoft Teams is the primary tool for internal communication, meetings, and file sharing."),
        new DocumentChunk("it-source-control", "it-environment.txt", "Source code is managed through Azure DevOps Git repositories. All commits require pull request reviews."),
        new DocumentChunk("it-deploy", "it-environment.txt", "Deployments follow CI/CD pipelines configured in Azure DevOps. Production deployments require team lead sign-off."),
        new DocumentChunk("it-environments", "it-environment.txt", "The company maintains four environments: Development (DEV), Quality Assurance (QA), Staging (UAT), and Production (PROD)."),
        new DocumentChunk("it-dev-env", "it-environment.txt", "The DEV environment is used for active development and testing by developers. It resets every weekend."),
        new DocumentChunk("it-qa-env", "it-environment.txt", "The QA environment is managed by the testing team. Builds are deployed here after developer testing in DEV."),
        new DocumentChunk("it-uat-env", "it-environment.txt", "The UAT (Staging) environment is used for client demos and user acceptance testing before production release."),
        new DocumentChunk("it-prod-env", "it-environment.txt", "The Production environment serves live users. Only approved and tested builds are deployed to PROD."),
        new DocumentChunk("it-db", "it-environment.txt", "Databases used include SQL Server for production, PostgreSQL for analytics, and Redis for caching."),
        new DocumentChunk("it-cloud", "it-environment.txt", "The company uses Microsoft Azure as the primary cloud provider for hosting, storage, and compute services."),
        new DocumentChunk("it-security", "it-environment.txt", "All systems require multi-factor authentication (MFA). USB ports are disabled on office machines for data security."),
        new DocumentChunk("it-helpdesk", "it-environment.txt", "IT helpdesk is available from 8AM to 8PM. Tickets can be raised via email to itsupport@company.com or through the support portal."),

        /* ── Leave Policy (Detailed) ── */
        new DocumentChunk("leave-casual", "leave-policy.txt", "Employees are entitled to 12 casual leaves per year. Casual leave cannot exceed 3 consecutive days."),
        new DocumentChunk("leave-sick", "leave-policy.txt", "Employees get 10 sick leaves per year. Medical certificate is required for sick leave exceeding 2 consecutive days."),
        new DocumentChunk("leave-earned", "leave-policy.txt", "Earned leaves accrue at 1.5 days per month (18 per year). Unused earned leave can be carried forward or encashed."),
        new DocumentChunk("leave-maternity", "leave-policy.txt", "Female employees are entitled to 26 weeks of paid maternity leave as per the Maternity Benefit Act."),
        new DocumentChunk("leave-paternity", "leave-policy.txt", "Male employees are entitled to 5 days of paid paternity leave within one month of the child's birth."),
        new DocumentChunk("leave-comp-off", "leave-policy.txt", "Compensatory off is granted for working on holidays or weekends. Comp-off must be used within 30 days."),
        new DocumentChunk("leave-bereavement", "leave-policy.txt", "Employees are granted up to 5 days of bereavement leave for the loss of an immediate family member."),
        new DocumentChunk("leave-lop", "leave-policy.txt", "Loss of Pay (LOP) is applied when an employee has exhausted all available leave types and takes additional leave."),
        new DocumentChunk("leave-half-day", "leave-policy.txt", "Half-day leave can be taken for the first half (9AM–1PM) or second half (2PM–6PM) with manager approval."),
        new DocumentChunk("leave-sandwich", "leave-policy.txt", "The sandwich rule applies: if leave is taken on Friday and Monday, Saturday and Sunday are also counted as leave days."),

        /* ── Dress Code Policy ── */
        new DocumentChunk("dress-formal", "dress-code.txt", "Monday to Thursday: formal dress code is mandatory. Men should wear collared shirts and trousers. Women should wear formal or semi-formal attire."),
        new DocumentChunk("dress-casual-friday", "dress-code.txt", "Casual Friday: employees may wear smart casual clothing including jeans and polo t-shirts. Shorts and slippers are not allowed."),
        new DocumentChunk("dress-id-badge", "dress-code.txt", "Employee ID badges must be visibly worn at all times inside the office premises."),
        new DocumentChunk("dress-client-visit", "dress-code.txt", "On client visit days, all employees must follow strict formal dress code regardless of the day of the week."),

        /* ── Office Timings & Attendance ── */
        new DocumentChunk("time-shift-general", "office-timings.txt", "General shift timing is 9:00AM to 6:00PM with a one-hour lunch break from 1:00PM to 2:00PM."),
        new DocumentChunk("time-shift-flexible", "office-timings.txt", "Flexible timing is available: employees may choose between 8AM–5PM, 9AM–6PM, or 10AM–7PM with manager approval."),
        new DocumentChunk("time-grace-period", "office-timings.txt", "A grace period of 15 minutes is allowed for morning login. Arrival after 9:15AM is considered late."),
        new DocumentChunk("time-late-penalty", "office-timings.txt", "Three late arrivals in a month result in a half-day leave deduction. Six or more result in a full-day deduction."),
        new DocumentChunk("time-night-shift", "office-timings.txt", "Night shift employees work from 7PM to 4AM with a cab facility provided by the company."),
        new DocumentChunk("time-min-hours", "office-timings.txt", "Employees must complete a minimum of 8.5 working hours per day excluding lunch break."),

        /* ── Salary & Compensation ── */
        new DocumentChunk("salary-date", "salary-policy.txt", "Salary is credited on the last working day of every month by 6PM."),
        new DocumentChunk("salary-structure", "salary-policy.txt", "Salary components include Basic Pay, HRA, Conveyance Allowance, Special Allowance, PF, and Professional Tax deductions."),
        new DocumentChunk("salary-increment", "salary-policy.txt", "Annual salary increments are effective from April 1st every year, based on performance appraisal ratings."),
        new DocumentChunk("salary-bonus", "salary-policy.txt", "Performance bonus is paid once a year in the month of April along with the regular salary."),
        new DocumentChunk("salary-tax", "salary-policy.txt", "Tax declarations must be submitted by January 31st each year. IT proofs must be uploaded to the HR portal by March 15th."),
        new DocumentChunk("salary-pf", "salary-policy.txt", "Employee PF contribution is 12% of basic pay. The company matches the contribution. PF statements are available on the EPFO portal."),

        /* ── Employee Benefits ── */
        new DocumentChunk("benefit-referral", "benefits.txt", "Employee referral bonus ranges from Rs.15,000 to Rs.50,000 depending on the position level of the referred candidate."),
        new DocumentChunk("benefit-certification", "benefits.txt", "The company reimburses up to Rs.10,000 per year for professional certifications (AWS, Azure, Scrum, etc.)."),
        new DocumentChunk("benefit-education", "benefits.txt", "Education assistance of up to Rs.25,000 per year is available for employees pursuing higher education related to their role."),
        new DocumentChunk("benefit-wellness", "benefits.txt", "Annual health checkup is arranged free of cost for all employees and their spouses."),
        new DocumentChunk("benefit-team-outing", "benefits.txt", "Each team gets a quarterly team outing budget of Rs.2,000 per person funded by the company."),
        new DocumentChunk("benefit-birthday", "benefits.txt", "Employees receive a birthday gift voucher worth Rs.500 and a half-day optional leave on their birthday."),

        /* ── Anti-Harassment / POSH Policy ── */
        new DocumentChunk("posh-policy", "posh-policy.txt", "The company has a zero-tolerance policy towards sexual harassment in the workplace as per the POSH Act 2013."),
        new DocumentChunk("posh-committee", "posh-policy.txt", "An Internal Complaints Committee (ICC) is established to address all harassment complaints. The ICC is led by a senior female employee."),
        new DocumentChunk("posh-complaint", "posh-policy.txt", "Harassment complaints can be submitted in writing to the ICC, through HR, or via the anonymous complaint portal within 90 days of the incident."),
        new DocumentChunk("posh-investigation", "posh-policy.txt", "All complaints are investigated confidentially within 30 days. The identity of the complainant is kept strictly confidential."),
        new DocumentChunk("posh-training", "posh-policy.txt", "Mandatory POSH awareness training is conducted for all employees once a year. Completion is tracked by HR."),
        new DocumentChunk("posh-action", "posh-policy.txt", "Disciplinary action for harassment includes warning, suspension, termination, or legal proceedings depending on severity."),
        new DocumentChunk("posh-protection", "posh-policy.txt", "Employees who file complaints are protected from retaliation. Any retaliatory behavior is treated as a separate violation."),

        /* ── Grievance Redressal ── */
        new DocumentChunk("grievance-process", "grievance-policy.txt", "Employees can raise workplace grievances through the HR portal, email to hr@company.com, or directly with their HR Business Partner."),
        new DocumentChunk("grievance-types", "grievance-policy.txt", "Grievances may include unfair treatment, workload issues, salary disputes, manager conflicts, discrimination, or policy violations."),
        new DocumentChunk("grievance-timeline", "grievance-policy.txt", "All grievances are acknowledged within 2 working days and resolved within 15 working days. Complex cases may take up to 30 days."),
        new DocumentChunk("grievance-escalation", "grievance-policy.txt", "If the grievance is not resolved satisfactorily, employees can escalate to the Grievance Committee headed by the HR Director."),
        new DocumentChunk("grievance-anonymous", "grievance-policy.txt", "Anonymous grievance submission is available through the company's ethics hotline and the anonymous feedback portal."),
        new DocumentChunk("grievance-confidential", "grievance-policy.txt", "All grievances are handled with strict confidentiality. Details are shared only with those directly involved in the resolution."),

        /* ── Code of Conduct & Ethics ── */
        new DocumentChunk("conduct-integrity", "code-of-conduct.txt", "Employees must act with honesty and integrity in all professional interactions with colleagues, clients, and vendors."),
        new DocumentChunk("conduct-conflict", "code-of-conduct.txt", "Employees must disclose any conflict of interest, such as working with a competitor or having a financial interest in a vendor company."),
        new DocumentChunk("conduct-gifts", "code-of-conduct.txt", "Employees must not accept gifts or favors worth more than Rs.1,000 from clients or vendors without reporting to their manager and HR."),
        new DocumentChunk("conduct-bribery", "code-of-conduct.txt", "Bribery and corruption are strictly prohibited. Any offer or acceptance of bribes must be reported immediately to the ethics team."),
        new DocumentChunk("conduct-discrimination", "code-of-conduct.txt", "Discrimination based on gender, religion, caste, age, disability, or sexual orientation is strictly prohibited in the workplace."),
        new DocumentChunk("conduct-substance", "code-of-conduct.txt", "Consumption of alcohol and drugs on office premises is strictly prohibited. Employees found under the influence will face disciplinary action."),
        new DocumentChunk("conduct-social-media", "code-of-conduct.txt", "Employees must not post confidential company information, client details, or offensive content on social media platforms."),
        new DocumentChunk("conduct-moonlighting", "code-of-conduct.txt", "Employees must not take up secondary employment or freelance work without prior written approval from HR and their reporting manager."),
        new DocumentChunk("conduct-violation", "code-of-conduct.txt", "Violations of the code of conduct may result in warnings, suspension, termination, or legal action depending on the severity."),

        /* ── Data Protection & Privacy Policy ── */
        new DocumentChunk("data-personal", "data-privacy.txt", "Employee personal data is collected only for legitimate business purposes and is stored securely in compliance with data protection regulations."),
        new DocumentChunk("data-client", "data-privacy.txt", "Client data must be handled with the highest level of confidentiality. Sharing client data externally without authorization is a terminable offense."),
        new DocumentChunk("data-usb", "data-privacy.txt", "USB drives and external storage devices are prohibited on office machines. Data transfer must use approved secure channels only."),
        new DocumentChunk("data-email", "data-privacy.txt", "Sensitive documents must not be sent via personal email accounts. Only company email with encryption should be used for confidential information."),
        new DocumentChunk("data-clean-desk", "data-privacy.txt", "The clean desk policy requires employees to lock screens when away and store sensitive documents in locked drawers at end of day."),
        new DocumentChunk("data-breach", "data-privacy.txt", "Any suspected data breach must be reported immediately to the IT security team at security@company.com. Do not attempt to fix it independently."),
        new DocumentChunk("data-disposal", "data-privacy.txt", "Printed documents containing sensitive information must be shredded using the shredders available on each floor before disposal."),
        new DocumentChunk("data-ndas", "data-privacy.txt", "All employees sign a Non-Disclosure Agreement (NDA) during onboarding that remains in effect for 2 years after leaving the company."),

        /* ── Travel & Business Expense Policy ── */
        new DocumentChunk("travel-approval", "travel-policy.txt", "All business travel must be pre-approved by the reporting manager and the finance team at least 5 working days before the travel date."),
        new DocumentChunk("travel-booking", "travel-policy.txt", "Flight and hotel bookings must be made through the company's approved travel portal. Personal bookings are not reimbursed."),
        new DocumentChunk("travel-allowance", "travel-policy.txt", "Daily travel allowance for domestic trips: Rs.1,500 for Tier-1 cities, Rs.1,000 for Tier-2 cities, Rs.800 for other locations."),
        new DocumentChunk("travel-hotel", "travel-policy.txt", "Hotel stay is covered up to Rs.3,500 per night for Tier-1 cities and Rs.2,500 per night for other locations. Exceeding limits requires VP approval."),
        new DocumentChunk("travel-meals", "travel-policy.txt", "Meal expenses during travel are reimbursed up to Rs.500 per meal (breakfast Rs.150, lunch Rs.200, dinner Rs.150) with receipts."),
        new DocumentChunk("travel-cab", "travel-policy.txt", "Local cab expenses during business travel are reimbursed with valid receipts. Auto-rickshaw and metro fares are also covered."),
        new DocumentChunk("travel-international", "travel-policy.txt", "International travel requires VP and HR approval. Visa processing, forex, and travel insurance are arranged by the admin team."),
        new DocumentChunk("travel-claim", "travel-policy.txt", "Travel expense claims must be submitted within 7 working days of return with all original receipts through the finance portal."),
        new DocumentChunk("travel-advance", "travel-policy.txt", "Travel advance up to 80% of estimated trip cost can be requested and is adjusted against the final expense claim."),

        /* ── Employee Exit & Full & Final Settlement ── */
        new DocumentChunk("exit-resignation", "exit-policy.txt", "Employees must submit resignation through the HR portal. The notice period is 30 days for confirmed employees and 15 days during probation."),
        new DocumentChunk("exit-buyout", "exit-policy.txt", "Notice period buyout is allowed with manager and HR approval. The buyout amount equals basic salary for the remaining notice days."),
        new DocumentChunk("exit-handover", "exit-policy.txt", "A complete knowledge transfer and project handover document must be submitted to the reporting manager before the last working day."),
        new DocumentChunk("exit-assets", "exit-policy.txt", "All company assets including laptop, ID card, access card, headphones, and parking sticker must be returned to IT and admin on the last day."),
        new DocumentChunk("exit-fnf", "exit-policy.txt", "Full and Final settlement is processed within 45 days of the last working day. It includes pending salary, earned leave encashment, and deductions."),
        new DocumentChunk("exit-experience", "exit-policy.txt", "Experience and relieving letters are issued within 7 working days after Full & Final settlement is completed."),
        new DocumentChunk("exit-interview", "exit-policy.txt", "Exit interviews are conducted by HR on the last working day. Feedback is kept confidential and used for organizational improvement."),
        new DocumentChunk("exit-rehire", "exit-policy.txt", "Former employees may apply for rehire after a cooling period of 6 months, subject to the hiring manager's approval."),
        new DocumentChunk("exit-clearance", "exit-policy.txt", "The exit clearance form must be signed by the reporting manager, IT, admin, finance, and HR before the last working day."),

        /* ── Employee Engagement & Events ── */
        new DocumentChunk("engage-townhall", "engagement.txt", "Company-wide town hall meetings are conducted quarterly by the CEO to share business updates, achievements, and future plans."),
        new DocumentChunk("engage-hackathon", "engagement.txt", "Internal hackathons are organized twice a year. Teams of 3–5 members can participate and winners receive cash prizes up to Rs.50,000."),
        new DocumentChunk("engage-sports", "engagement.txt", "Annual sports day is held in January with cricket, badminton, table tennis, and relay races. Participation is open to all employees."),
        new DocumentChunk("engage-festival", "engagement.txt", "Festival celebrations including Pongal, Diwali, Christmas, and Onam are organized in the office with decorations, food, and cultural programs."),
        new DocumentChunk("engage-awards", "engagement.txt", "Employee of the Month awards are announced on the first Monday of every month with a certificate and Rs.5,000 gift voucher."),
        new DocumentChunk("engage-star-performer", "engagement.txt", "Star Performer of the Quarter is selected based on project delivery, client feedback, and peer nominations. Winners receive Rs.15,000."),
        new DocumentChunk("engage-anniversary", "engagement.txt", "Work anniversary milestones (1, 3, 5, 10 years) are celebrated with personalized gifts and recognition in the company newsletter."),
        new DocumentChunk("engage-volunteering", "engagement.txt", "CSR volunteering days are organized quarterly. Employees get one paid volunteering day per quarter to participate in community service."),
        new DocumentChunk("engage-newsletter", "engagement.txt", "A monthly company newsletter is published with project highlights, new joiners, birthdays, achievements, and upcoming events."),
        new DocumentChunk("engage-clubs", "engagement.txt", "Employee clubs include Photography Club, Book Club, Coding Club, Fitness Club, and Music Club. Employees can join through the intranet."),

        /* ── Performance Improvement Plan (PIP) ── */
        new DocumentChunk("pip-trigger", "pip-policy.txt", "A Performance Improvement Plan is initiated when an employee receives a 'Below Expectations' rating in two consecutive quarterly reviews."),
        new DocumentChunk("pip-duration", "pip-policy.txt", "The standard PIP duration is 60 days with clear, measurable goals set jointly by the employee, manager, and HR."),
        new DocumentChunk("pip-review", "pip-policy.txt", "PIP progress is reviewed bi-weekly by the reporting manager. A mid-PIP review at day 30 determines if the employee is on track."),
        new DocumentChunk("pip-success", "pip-policy.txt", "If the employee successfully meets all PIP goals, the PIP is closed and the employee continues in their role with normal performance tracking."),
        new DocumentChunk("pip-failure", "pip-policy.txt", "If PIP goals are not met after the full duration, consequences may include role change, demotion, extended PIP, or termination."),
        new DocumentChunk("pip-support", "pip-policy.txt", "Employees on PIP receive additional support including mentoring, training resources, and weekly check-ins with their manager."),

        /* ── Workplace Safety & Ergonomics ── */
        new DocumentChunk("safety-emergency", "workplace-safety.txt", "Emergency evacuation assembly points are located in the parking area. Floor wardens guide employees during fire or earthquake drills."),
        new DocumentChunk("safety-fire-drill", "workplace-safety.txt", "Fire drills are conducted once every quarter. All employees must participate and follow the evacuation route displayed on each floor."),
        new DocumentChunk("safety-earthquake", "workplace-safety.txt", "In case of earthquake, employees should take cover under desks, avoid elevators, and evacuate to the assembly point after shaking stops."),
        new DocumentChunk("safety-ergonomics", "workplace-safety.txt", "Ergonomic assessments are available on request from the admin team. Adjustable chairs, monitor stands, and footrests can be provided."),
        new DocumentChunk("safety-eye-strain", "workplace-safety.txt", "Employees are advised to follow the 20-20-20 rule: every 20 minutes, look at something 20 feet away for 20 seconds to reduce eye strain."),
        new DocumentChunk("safety-incident", "workplace-safety.txt", "Workplace incidents or injuries must be reported immediately to the admin team and security. An incident report form must be filled within 24 hours."),
        new DocumentChunk("safety-electrical", "workplace-safety.txt", "Employees must not tamper with electrical wiring or equipment. Any electrical issues must be reported to the facilities team immediately."),
        new DocumentChunk("safety-wet-floor", "workplace-safety.txt", "Housekeeping places wet floor signs during cleaning. Employees should exercise caution in marked areas to prevent slips and falls."),

        /* ── Communication & Email Etiquette ── */
        new DocumentChunk("comm-email-response", "communication-policy.txt", "Internal emails should be responded to within 4 working hours. Client emails require a response within 2 working hours."),
        new DocumentChunk("comm-email-format", "communication-policy.txt", "Professional email format: clear subject line, greeting, concise body, action items highlighted, and a proper signature with designation."),
        new DocumentChunk("comm-cc-bcc", "communication-policy.txt", "Use CC for stakeholders who need visibility. Use BCC only for large distribution lists. Avoid unnecessary Reply All."),
        new DocumentChunk("comm-escalation", "communication-policy.txt", "Escalation matrix: Team Lead (1st level) → Project Manager (2nd level) → Delivery Head (3rd level) → CTO (final level)."),
        new DocumentChunk("comm-teams-status", "communication-policy.txt", "Employees should keep their Microsoft Teams status updated during working hours: Available, Busy, In a Meeting, or Away."),
        new DocumentChunk("comm-meetings-etiquette", "communication-policy.txt", "Meeting etiquette: join on time, mute when not speaking, use video when possible, share agenda beforehand, and send minutes after."),
        new DocumentChunk("comm-slack-channels", "communication-policy.txt", "Teams channels are organized by project and department. Use #general for announcements, #random for casual chat, and project channels for work discussions."),
        new DocumentChunk("comm-urgent", "communication-policy.txt", "For urgent matters outside working hours, contact the reporting manager via phone call. Do not use email or chat for emergencies."),

        /* ── Company Overview ── */
        new DocumentChunk("company-about", "company-info.txt", "The company is a leading IT services and software development firm headquartered in Chennai, Tamil Nadu, India. Founded in 2015."),
        new DocumentChunk("company-mission", "company-info.txt", "Our mission is to deliver innovative technology solutions that empower businesses and create meaningful impact for our clients."),
        new DocumentChunk("company-values", "company-info.txt", "Core values: Integrity, Innovation, Customer Focus, Teamwork, and Continuous Learning. These guide all our decisions and actions."),
        new DocumentChunk("company-size", "company-info.txt", "The company has over 500 employees across three offices: Chennai (HQ), Bangalore, and Hyderabad."),
        new DocumentChunk("company-clients", "company-info.txt", "We serve clients in banking, healthcare, retail, and logistics sectors across India, the US, the UK, and the Middle East."),
        new DocumentChunk("company-departments", "company-info.txt", "Key departments include Software Development, Quality Assurance, DevOps, Data Engineering, HR, Finance, Admin, and Sales."),
        new DocumentChunk("company-ceo", "company-info.txt", "The CEO communicates company updates through quarterly town halls and monthly email newsletters."),
        new DocumentChunk("company-website", "company-info.txt", "The company website and careers page can be accessed at www.company.com. The employee intranet is available at intranet.company.com."),

        /* ── Internship Program ── */
        new DocumentChunk("intern-eligibility", "internship-policy.txt", "Internship positions are open to final-year students and recent graduates. Applications are accepted through the careers portal."),
        new DocumentChunk("intern-duration", "internship-policy.txt", "Internship duration is 3 to 6 months depending on the project and department. Extensions may be granted based on performance."),
        new DocumentChunk("intern-stipend", "internship-policy.txt", "Interns receive a monthly stipend of Rs.10,000 to Rs.15,000 based on the role. Stipend is credited on the last working day of each month."),
        new DocumentChunk("intern-mentor", "internship-policy.txt", "Each intern is assigned a dedicated mentor who provides guidance, conducts weekly reviews, and evaluates performance."),
        new DocumentChunk("intern-conversion", "internship-policy.txt", "Top-performing interns may receive a full-time job offer at the end of the internship based on performance evaluation and business need."),
        new DocumentChunk("intern-certificate", "internship-policy.txt", "All interns receive an internship completion certificate. Performance-based recommendation letters are provided upon request."),
        new DocumentChunk("intern-hours", "internship-policy.txt", "Intern working hours are 9AM to 5PM, Monday to Friday. Interns are not required to work overtime or weekends."),
        new DocumentChunk("intern-leave", "internship-policy.txt", "Interns are entitled to 2 days of casual leave per month. Leave must be approved by the assigned mentor."),

        /* ── Mental Health & Employee Assistance ── */
        new DocumentChunk("mental-eap", "mental-health.txt", "The Employee Assistance Program (EAP) provides free and confidential counseling services for stress, anxiety, and personal challenges."),
        new DocumentChunk("mental-counselor", "mental-health.txt", "Professional counselors are available for in-person sessions every Wednesday or virtual sessions any weekday by appointment."),
        new DocumentChunk("mental-helpline", "mental-health.txt", "The 24/7 mental health helpline number is 1800-XXX-XXXX. All calls are completely confidential and free for employees."),
        new DocumentChunk("mental-stress", "mental-health.txt", "If an employee is experiencing burnout or excessive stress, they should speak to their manager or HR for workload adjustments."),
        new DocumentChunk("mental-workshops", "mental-health.txt", "Monthly wellness workshops cover topics like mindfulness, work-life balance, financial planning, and stress management techniques."),
        new DocumentChunk("mental-yoga", "mental-health.txt", "Yoga and meditation sessions are conducted every Tuesday and Thursday morning from 7:30AM to 8:15AM in the terrace area."),
        new DocumentChunk("mental-leave", "mental-health.txt", "Employees may take mental health days using their sick leave balance. No medical certificate is required for single-day mental health leave."),
        new DocumentChunk("mental-manager-training", "mental-health.txt", "Managers receive annual training on recognizing signs of employee burnout and providing appropriate support and accommodations."),

        /* ── Internal Job Posting & Transfers ── */
        new DocumentChunk("ijp-policy", "ijp-policy.txt", "Internal Job Postings (IJP) are published on the HR portal. Employees who have completed 1 year in their current role are eligible to apply."),
        new DocumentChunk("ijp-process", "ijp-policy.txt", "IJP applications go through screening, interview rounds, and manager discussion. The current manager is informed before the final round."),
        new DocumentChunk("ijp-transfer", "ijp-policy.txt", "Inter-department transfers are processed within 30 days of selection. The transition period allows for proper knowledge handover."),
        new DocumentChunk("ijp-relocation", "ijp-policy.txt", "If a transfer requires relocation to another city office, the company provides a one-time relocation allowance of Rs.50,000."),
        new DocumentChunk("ijp-retention", "ijp-policy.txt", "Employees cannot apply for another IJP within 6 months of a successful internal transfer."),

        /* ── Contractor & Vendor Policy ── */
        new DocumentChunk("vendor-access", "vendor-policy.txt", "Contractors and vendors are issued temporary access cards valid for the contract duration. They must be accompanied by a company employee in restricted areas."),
        new DocumentChunk("vendor-nda", "vendor-policy.txt", "All contractors must sign an NDA before accessing company systems or client data. Vendor companies sign a master service agreement."),
        new DocumentChunk("vendor-workspace", "vendor-policy.txt", "Contractors are allocated workstations in designated vendor seating areas. They have limited network access and cannot use company printers."),
        new DocumentChunk("vendor-payment", "vendor-policy.txt", "Vendor invoices are processed through the finance portal. Payment terms are Net 30 days from invoice submission."),
        new DocumentChunk("vendor-review", "vendor-policy.txt", "Vendor performance is reviewed quarterly by the project manager and procurement team. Underperformance may lead to contract termination."),

        /* ── Office Stationery & Supplies ── */
        new DocumentChunk("stationery-request", "stationery-policy.txt", "Office stationery (pens, notebooks, sticky notes, markers) can be requested through the admin portal or from the supply room on the 2nd floor."),
        new DocumentChunk("stationery-laptop-accessories", "stationery-policy.txt", "Laptop accessories like chargers, USB-C hubs, and laptop stands can be requested from the IT team with manager approval."),
        new DocumentChunk("stationery-business-cards", "stationery-policy.txt", "Business cards can be ordered through the admin team. Allow 5 working days for printing. First batch of 100 cards is free."),
        new DocumentChunk("stationery-printing", "stationery-policy.txt", "Color printing is limited to 50 pages per month per employee. Bulk printing requests must be approved by the admin team."),

        /* ── Company Contact Directory ── */
        new DocumentChunk("contact-hr", "contact-directory.txt", "HR Department: hr@company.com | Extension: 201 | Available: 9AM–6PM Monday to Friday."),
        new DocumentChunk("contact-it", "contact-directory.txt", "IT Helpdesk: itsupport@company.com | Extension: 301 | Available: 8AM–8PM Monday to Friday."),
        new DocumentChunk("contact-finance", "contact-directory.txt", "Finance Department: finance@company.com | Extension: 401 | For salary, reimbursement, and tax queries."),
        new DocumentChunk("contact-admin", "contact-directory.txt", "Admin & Facilities: facilities@company.com | Extension: 501 | For office maintenance, stationery, and cab requests."),
        new DocumentChunk("contact-security", "contact-directory.txt", "Security Desk: Extension 100 | Available 24/7 | For access card issues, visitor registration, and emergency situations."),
        new DocumentChunk("contact-cafeteria", "contact-directory.txt", "Cafeteria Manager: cafeteria@company.com | Extension: 601 | For meal bookings, dietary requests, and food feedback."),
        new DocumentChunk("contact-transport", "contact-directory.txt", "Transport Helpline: transport@company.com | Extension: 701 | For cab bookings, route changes, and night shift transport."),
        new DocumentChunk("contact-ethics", "contact-directory.txt", "Ethics Hotline: ethics@company.com | Anonymous reporting portal available at ethics.company.com for confidential complaints."),

        /* ── Overall / Summary Entries ── */

        new DocumentChunk("overall-policies", "overall-summary.txt",
            "The company has the following policies: Attendance Policy (biometric login before 9:15AM), Leave Policy (casual, sick, earned, maternity, paternity, comp-off, bereavement, LOP), " +
            "Work From Home Policy (max 8 days/month, hybrid model with Tue/Wed/Thu in-office), Dress Code Policy (formal Mon–Thu, casual Friday), " +
            "Code of Conduct (integrity, no moonlighting, no gifts above Rs.1000, no substance abuse), Anti-Harassment / POSH Policy (zero tolerance, ICC committee), " +
            "Data Protection & Privacy Policy (clean desk, NDA, no USB, shredding), Travel & Expense Policy (pre-approval, daily allowance, hotel limits), " +
            "Grievance Redressal Policy (HR portal, resolved in 15 days), Communication Policy (email etiquette, escalation matrix), " +
            "Performance Improvement Plan Policy (60-day PIP for underperformers), Exit Policy (30-day notice, F&F in 45 days), " +
            "Workplace Safety Policy (fire drills, ergonomics, incident reporting), and Internet & Social Media Policy (limited personal browsing, no confidential info on social media). " +
            "All policies are available in the employee handbook on the company intranet."),

        new DocumentChunk("overall-leaves", "overall-summary.txt",
            "Overall leave entitlement per year: Casual Leave – 12 days (max 3 consecutive), Sick Leave – 10 days (medical certificate needed after 2 days), " +
            "Earned Leave – 18 days (1.5 per month, can carry forward or encash), Maternity Leave – 26 weeks paid (as per POSH Act), " +
            "Paternity Leave – 5 days paid (within 1 month of child's birth), Bereavement Leave – up to 5 days, " +
            "Compensatory Off – for working on holidays/weekends (use within 30 days), Half-Day Leave – available for first or second half with approval. " +
            "Loss of Pay (LOP) applies when all leave types are exhausted. The sandwich rule applies: leave on Friday + Monday counts Saturday and Sunday as leave. " +
            "Leave balance can be checked on the HR portal. All leaves require reporting manager approval."),

        new DocumentChunk("overall-benefits", "overall-summary.txt",
            "Overall employee benefits include: Health Insurance (employee + spouse + children, cashless at network hospitals), Life Insurance, Accidental Insurance, Dental Coverage (premium plans), " +
            "Maternity/Paternity Coverage, Annual Health Checkup (free for employee and spouse), Employee Referral Bonus (Rs.15,000–Rs.50,000), " +
            "Certification Reimbursement (up to Rs.10,000/year for AWS, Azure, Scrum etc.), Education Assistance (up to Rs.25,000/year), " +
            "Team Outing Budget (Rs.2,000 per person per quarter), Birthday Gift Voucher (Rs.500 + half-day leave), " +
            "Subsidized Lunch (Rs.30/meal), Free Snacks and Tea/Coffee, Gym Access (free, 6AM–9PM), Recreation Room (TT, foosball, PlayStation), " +
            "Transport for Night Shift, Parking Facility, Employee Assistance Program (free counseling), Yoga & Meditation Sessions, " +
            "Monthly Wellness Workshops, CSR Volunteering Days (1 paid day per quarter), and Work Anniversary Recognition Gifts."),

        new DocumentChunk("overall-holidays", "overall-summary.txt",
            "Overall holiday list: New Year (Jan 1), Pongal (3 days in January), Republic Day (Jan 26), Good Friday, Labour Day (May 1), " +
            "Independence Day (Aug 15), Ganesh Chaturthi (optional), Gandhi Jayanthi (Oct 2), Diwali (dates vary), Christmas (Dec 25). " +
            "Weekly off: Saturday and Sunday. Employees also get 2 optional holidays per year (cannot carry forward). " +
            "Festival holidays are communicated by HR through official email. The annual holiday calendar is released by HR in January. " +
            "Regional festival holidays may also be declared. Upcoming holiday schedules are available on the HR portal and Microsoft Teams announcements."),

        new DocumentChunk("overall-office-timings", "overall-summary.txt",
            "Overall office timings: General shift is 9:00AM to 6:00PM with lunch from 1:00PM to 2:00PM. " +
            "Flexible timing options: 8AM–5PM, 9AM–6PM, or 10AM–7PM (with manager approval). Night shift: 7PM–4AM (cab facility provided). " +
            "Grace period: 15 minutes (login by 9:15AM). Late penalty: 3 late arrivals = half-day deduction, 6+ = full-day deduction. " +
            "Minimum working hours: 8.5 hours per day excluding lunch. Biometric attendance is mandatory. " +
            "Overtime requires prior manager approval. Extended lunch beyond 2PM must be compensated with extra working time."),

        new DocumentChunk("overall-wfh", "overall-summary.txt",
            "Overall Work From Home summary: Eligible after 6-month probation. Maximum 8 WFH days per month. " +
            "Hybrid model: Tuesday, Wednesday, and Thursday are mandatory in-office days. Friday is an optional WFH day (with team lead approval). " +
            "WFH requests must be submitted 1 day in advance via HR portal and approved by the reporting manager. " +
            "WFH attendance must be logged before 9:15AM. Must use company laptop and VPN. Must be reachable on Teams and email during 9AM–6PM. " +
            "Internet must be at least 10 Mbps (not reimbursed). Camera required in meetings when requested. " +
            "Emergency WFH allowed without prior approval but manager must be informed within 1 hour. " +
            "WFH privileges can be revoked for being unreachable or unproductive."),

        new DocumentChunk("overall-food", "overall-summary.txt",
            "Overall food and snacks summary: Breakfast available in cafeteria from 8AM. Morning snacks (free): 10:00AM–10:30AM (biscuits, toast, bananas, tea/coffee). " +
            "Lunch: 1:00PM–2:00PM (cafeteria open 12:30PM–2:30PM). Lunch cost: Rs.30/meal (subsidized, deducted from salary). " +
            "Menu rotates daily: rice, chapati, curries, dal, salad, curd, dessert on Fridays. Veg and non-veg options available (non-veg on Tue/Thu/Fri). " +
            "Must pre-book lunch by 10:30AM via cafeteria app. Evening snacks (free): 4:00PM–4:30PM (samosa, vada, sandwich). " +
            "Tea/coffee vending machines: 24/7 on every floor (unlimited, free). Vending machines with packaged snacks available (paid via ID card). " +
            "Pantry locations: 2nd and 5th floors. Microwave available for outside food. Special dietary needs can be requested. " +
            "Guest meals: Rs.100 (inform admin 2 hours before). Cafeteria operates until 7PM."),

        new DocumentChunk("overall-insurance", "overall-summary.txt",
            "Overall insurance summary: Health Insurance for all permanent employees covering employee, spouse, and children. " +
            "Cashless treatment at network hospitals. Insurance claims must be submitted within 30 days with bills and discharge summaries. " +
            "Accidental Insurance and Life Insurance included in benefits. Dental coverage available under premium plans. " +
            "Emergency ambulance charges covered. Maternity coverage included. Insurance premiums partially paid by company. " +
            "Policies renewed every financial year. Digital insurance cards issued after onboarding. Claim limits depend on employee grade. " +
            "For insurance assistance, contact HR."),

        new DocumentChunk("overall-salary", "overall-summary.txt",
            "Overall salary and compensation summary: Salary credited on the last working day of every month by 6PM. " +
            "Components: Basic Pay, HRA, Conveyance Allowance, Special Allowance, PF (12% employee + 12% company), Professional Tax. " +
            "Annual increment effective April 1st based on appraisal rating. Performance bonus paid in April. " +
            "Tax declarations due by January 31st; IT proofs by March 15th. Payslips downloadable from the self-service portal. " +
            "PF statements available on the EPFO portal. Overtime compensation depends on policy and manager approval. " +
            "Expense reimbursements processed within 7 working days via finance portal."),

        new DocumentChunk("overall-it-setup", "overall-summary.txt",
            "Overall IT setup summary: Developers get Dell/Lenovo i7 laptops (16GB RAM, 512GB SSD). OS: Windows 11 (general) or Ubuntu/macOS (developers). " +
            "Tools: Visual Studio, VS Code, Git, Docker, Postman, JIRA. Communication: Microsoft Teams and Outlook (Microsoft 365). " +
            "Source control: Azure DevOps Git with mandatory pull request reviews. CI/CD via Azure DevOps pipelines. " +
            "Four environments: DEV (resets weekly), QA (testing team), UAT (client demos), PROD (live). " +
            "Databases: SQL Server (production), PostgreSQL (analytics), Redis (caching). Cloud: Microsoft Azure. " +
            "VPN: GlobalProtect required for remote access. Security: MFA required, USB ports disabled. " +
            "IT helpdesk: 8AM–8PM, itsupport@company.com."),

        new DocumentChunk("overall-reporting", "overall-summary.txt",
            "Overall reporting structure summary: Every employee has a reporting manager assigned during onboarding. " +
            "Hierarchy: Intern → Junior Developer → Senior Developer → Team Lead → Project Manager → Delivery Head → CTO. " +
            "Reporting manager handles approvals for leave, WFH, overtime, and expenses. One-on-one meetings every 2 weeks. " +
            "Quarterly performance feedback through appraisal system. Skip-level meetings once per quarter. " +
            "Manager changes communicated by HR during project reassignments. Concerns can be escalated to skip-level manager or HR. " +
            "Each department has an HR Business Partner. Manager details visible in HR portal under 'My Profile → Reporting Structure'."),

        new DocumentChunk("overall-exit", "overall-summary.txt",
            "Overall exit process summary: Submit resignation through HR portal. Notice period: 30 days (confirmed) or 15 days (probation). " +
            "Notice buyout allowed with approval (basic salary for remaining days). Complete knowledge transfer and handover document before last day. " +
            "Return all assets (laptop, ID card, access card, headphones, parking sticker) to IT and admin. " +
            "Get exit clearance signed by manager, IT, admin, finance, and HR. Exit interview conducted by HR on last day. " +
            "Full & Final settlement processed within 45 days (includes pending salary, earned leave encashment, deductions). " +
            "Experience and relieving letters issued within 7 days after F&F. Rehire possible after 6-month cooling period."),

        new DocumentChunk("overall-engagement", "overall-summary.txt",
            "Overall employee engagement summary: Quarterly town halls by CEO. Internal hackathons twice a year (prizes up to Rs.50,000). " +
            "Annual sports day in January (cricket, badminton, TT, relay). Festival celebrations (Pongal, Diwali, Christmas, Onam). " +
            "Employee of the Month (Rs.5,000 voucher). Star Performer of the Quarter (Rs.15,000). Work anniversary recognition (1, 3, 5, 10 years). " +
            "CSR volunteering days (1 paid day per quarter). Monthly company newsletter. Employee clubs: Photography, Book, Coding, Fitness, Music. " +
            "Birthday gift voucher (Rs.500 + half-day leave). Team outing budget Rs.2,000 per person per quarter."),

        new DocumentChunk("overall-safety", "overall-summary.txt",
            "Overall workplace safety summary: Emergency assembly points in parking area. Fire drills every quarter (mandatory participation). " +
            "Earthquake procedure: take cover, avoid elevators, evacuate after shaking stops. Ergonomic assessments available on request. " +
            "20-20-20 rule for eye strain prevention. Incident reporting within 24 hours to admin and security. " +
            "Fire extinguishers on every floor. CCTV surveillance across campus. First aid kits at reception and every floor. " +
            "Wet floor signs during cleaning. No tampering with electrical equipment. Smoking only in designated zone in parking area."),

        new DocumentChunk("overall-contacts", "overall-summary.txt",
            "Key company contacts: HR – hr@company.com (Ext 201), IT Helpdesk – itsupport@company.com (Ext 301), " +
            "Finance – finance@company.com (Ext 401), Admin & Facilities – facilities@company.com (Ext 501), " +
            "Security – Ext 100 (24/7), Cafeteria – cafeteria@company.com (Ext 601), Transport – transport@company.com (Ext 701), " +
            "Ethics Hotline – ethics@company.com, Mental Health Helpline – 1800-XXX-XXXX (24/7). " +
            "For emergencies outside working hours, contact reporting manager via phone call."),

        new DocumentChunk("overall-onboarding", "overall-summary.txt",
            "Overall onboarding summary: New employee onboarding takes place every Monday. Documents required: ID proof, educational certificates, bank details, " +
            "passport-size photos, previous employment relieving letter. On Day 1: ID card issuance, laptop setup by IT, HR orientation, NDA signing, " +
            "insurance enrollment, biometric registration, reporting manager introduction, mentor assignment (for interns). " +
            "Probation period: 6 months. First week includes team introduction, system access setup, project briefing, and policy walkthrough. " +
            "Employee self-service portal access is granted within 24 hours of joining."),

        new DocumentChunk("overall-dress-code", "overall-summary.txt",
            "Overall dress code summary: Monday to Thursday – formal dress code mandatory (collared shirts, trousers for men; formal/semi-formal for women). " +
            "Friday – casual allowed (jeans, polo t-shirts; no shorts, no slippers). Client visit days – strict formal regardless of day. " +
            "ID badge must be visibly worn at all times inside office premises."),

        /* ── Employee Profile: Naveen Boopathy ── */
        new DocumentChunk("naveen-profile", "employee-naveen.txt", "Naveen Boopathy is a Senior Software Engineer at EC-Group Data Soft. He is based in Salem, Tamil Nadu."),
        new DocumentChunk("naveen-role", "employee-naveen.txt", "Naveen Boopathy's role is Senior Software Engineer. He works at EC-Group Data Soft."),
        new DocumentChunk("naveen-company", "employee-naveen.txt", "Naveen Boopathy works at EC-Group Data Soft."),
        new DocumentChunk("naveen-native", "employee-naveen.txt", "Naveen Boopathy's native place is Salem."),
        new DocumentChunk("naveen-client-manager", "employee-naveen.txt", "Naveen Boopathy's client manager is Bob Kozal. Bob Kozal is a cool guy, a guiding person, and very supportive."),
        new DocumentChunk("naveen-team-leader", "employee-naveen.txt", "Naveen Boopathy's team leader is Anand."),
        new DocumentChunk("naveen-team-members", "employee-naveen.txt", "Naveen Boopathy's team members are Anand, Manoj, Ravi, Pream, and Thiru."),
        new DocumentChunk("naveen-hr", "employee-naveen.txt", "The HR contacts for Naveen Boopathy are Kavitha, Bersin, Nicles, and Annie."),
        new DocumentChunk("naveen-friend", "employee-naveen.txt", "Naveen Boopathy's friend is the funny😄 boy VelMurugan."),
        new DocumentChunk("naveen-summary", "employee-naveen.txt",
            "Employee profile summary for Naveen Boopathy: Role – Senior Software Engineer at EC-Group Data Soft. " +
            "Native place – Salem. Client Manager – Bob Kozal (cool guy, guiding person, supportive). Team Leader – Anand. " +
            "Team Members – Manoj, Ravi, Pream, Thiru. HR Contacts – Kavitha, Bersin, Nicles, Annie. " +
            "Best Friend – the funny VelMurugan."),

        /* ── Fun / Easter Eggs (just for laughs) ── */
        new DocumentChunk("fun-leave", "fun.txt", "How to take leave? No bro, it's wrong bro. Go to office bro, increase your productivity bro. Leave is for the weak bro, deadlines don't take leave bro."),
        new DocumentChunk("fun-resign", "fun.txt", "Thinking of resigning? No bro, don't do it bro. Salary credit day is coming bro, stay strong bro. Your laptop will miss you bro."),
        new DocumentChunk("fun-wfh", "fun.txt", "Want to work from home? No bro, office coffee is free bro. Come and feel the AC bro, the chair is ergonomic bro."),
        new DocumentChunk("fun-late", "fun.txt", "Coming late again bro? No bro, 9:15AM is the deal bro. Set 5 alarms bro, biometric never sleeps bro."),
        new DocumentChunk("fun-overtime", "fun.txt", "Tired of overtime bro? That's the spirit bro, one more sprint bro. The bug won't fix itself bro, push to prod bro."),
        new DocumentChunk("fun-coffee", "fun.txt", "Need a break bro? Grab the free tea/coffee bro, it's 24/7 bro. Refuel and refactor bro, you got this bro."),
        new DocumentChunk("fun-meeting", "fun.txt", "Another meeting bro? Yes bro, mute yourself bro, turn camera on bro. This could've been an email bro, but here we are bro."),
        new DocumentChunk("fun-monday", "fun.txt", "Monday blues bro? No bro, town hall energy bro. Standup at 7.30pm bro, smile and commit bro."),
        new DocumentChunk("fun-bug", "fun.txt", "Found a bug bro? It's not a bug bro, it's your mistake bro 😄. Keep a smile on your face bro, fix it like a champion bro."),
        new DocumentChunk("fun-motivation", "fun.txt", "Feeling lazy bro? No bro, hustle bro, productivity is life bro. Touch grass after deployment bro, not before bro."),

    ];

    /// <summary>
    /// Returns the absolute path of THIS source file (KnowledgeBase.cs) on the build machine.
    /// Used by the document-upload feature to append new chunk entries.
    /// Note: the inner helper is called from within this file so that [CallerFilePath]
    /// resolves to KnowledgeBase.cs rather than the external caller's file.
    /// </summary>
    public static string SourceFilePath() => ResolveOwnPath();

    private static string ResolveOwnPath([CallerFilePath] string path = "") => path;
}
